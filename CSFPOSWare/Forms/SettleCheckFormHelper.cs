using CSFPOSWare.DAO;
using CSFPOSWare.Models;
using CSFPOSWare.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSFPOSWare.Forms
{
    
    public class SettleCheckFormHelper
    {
        public string amountDue = "55555";
        public string tenderAmountStr = "";
        public string balance = "";
        private List<Media> mediaList = null;
        private SettleCheckForm settleCheckForm = null;

        public SettleCheckFormHelper(SettleCheckForm settleCheckForm)
        {
            this.settleCheckForm = settleCheckForm;
        }
        
        public List<Button> loadMediaButtons()
        {
            MaintenanceDAO maintenanceDAO = new MaintenanceDAO();
            mediaList = maintenanceDAO.getMedia();
            int topMargin = 60;
            int itemLimit = 5;
            int count = 1;
            int left = 520;
            int[] leftButtons = { 0, 3, 6,9,12,15,18 };
            int[] middleButton = { 1, 4, 7, 10, 13, 16 };
            List<Button> mediaButtons = new List<Button>();
            foreach (Media media in mediaList)
            {
                if(!string.IsNullOrEmpty(media.MediaName.Trim()))
                {
                    int x = left;
                    int bHeight = 70;
                    if (leftButtons.Contains(count - 1))
                    {//Left button
                        x = left;
                    }
                    else if (middleButton.Contains(count -1))
                    {//middle button
                        x = left + 80;
                        topMargin -= bHeight;
                    }
                    else
                    {//right button
                        x = left + 160;
                        topMargin -= bHeight;
                    }

                    Point p = new Point(x, topMargin);
                    mediaButtons.Add(_addMediaButton(media.MediaIndex.ToString(), media.MediaName, p));
                    topMargin += bHeight;
                    count += 1;
                }
            }
            return mediaButtons;
        }//public void loadMedia(SettleCheckForm form)

        
        private string mediaButtonPrefix = "btnMedia_";
        private Button _addMediaButton(string mediaIndex, string label, Point loc)
        {
            Button button = new Button();
            button.Location = loc;
            button.Text = label;
            button.Width = 70;
            button.Height = 60;
            button.ForeColor = System.Drawing.Color.White;
            button.BackColor = System.Drawing.Color.LightBlue;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Name = mediaButtonPrefix + mediaIndex;

            button.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ButtonBGBlank));
            button.BackgroundImageLayout = ImageLayout.Stretch;

            return button;
        }

        public void type(Button b)
        {
            tenderAmountStr += b.Text;
            this.settleCheckForm.txtTenderAmount.Text = Util.Number.peso((decimal.Parse(tenderAmountStr)/100).ToString());
        }

        public void typeBill(Button b)
        {
            string amount = b.Text.Remove(0, 1) + "00";
            if (tenderAmountStr != "")
            {
                int tenderAmount = int.Parse(tenderAmountStr);
                tenderAmountStr = (tenderAmount + int.Parse(amount)).ToString();
            }
            else
            {
                tenderAmountStr = amount;
            }
            this.settleCheckForm.txtTenderAmount.Text = Util.Number.peso((decimal.Parse(tenderAmountStr) / 100).ToString());
        }

        public void clearTenderAmount()
        {
            tenderAmountStr = "";
            this.settleCheckForm.txtTenderAmount.Text = tenderAmountStr;
        }

        public void backspace()
        {
            if (tenderAmountStr.Length > 0)
            {
                tenderAmountStr = tenderAmountStr.Substring(0, tenderAmountStr.Length - 1);
            }
            else
            {
                tenderAmountStr = "";
                this.settleCheckForm.txtTenderAmount.Text = "";
            }

            if (tenderAmountStr.Length > 0)
            {
                this.settleCheckForm.txtTenderAmount.Text = Util.Number.peso((decimal.Parse(tenderAmountStr) / 100).ToString());
            }
            else
            {
                this.settleCheckForm.txtTenderAmount.Text = "";
            }
        }

        Dictionary<Media, decimal> usedTenders = null;
        public void useTender(Button button)
        {
            if (usedTenders == null)
                usedTenders = new Dictionary<Media, decimal>();

            string mediaIndex = button.Name.Replace(mediaButtonPrefix, "");
            Media media = mediaList[int.Parse(mediaIndex)];

            if (tenderAmountStr == "")
            {//tender exact
                tenderAmountStr = balance;
            }

            //Add to temp storage

            if (usedTenders.ContainsKey(media))
            {
                usedTenders[media] += decimal.Parse(tenderAmountStr);
            }
            else
            {
                usedTenders.Add(media, decimal.Parse(tenderAmountStr));
            }
            this.updateUsedTenders();

            
            tenderAmountStr = "";
            this.settleCheckForm.txtTenderAmount.Text ="";
        }
        private void updateUsedTenders()
        {
            this.settleCheckForm.lvTenders.Items.Clear();
            this.settleCheckForm.lvTenders.View = View.Details;
            this.settleCheckForm.lvTenders.Scrollable = true;
            this.settleCheckForm.lvTenders.HeaderStyle = ColumnHeaderStyle.None;
            foreach (KeyValuePair<Media, decimal> kvp in usedTenders)
            {
                string[] values = { kvp.Key.MediaName, Util.Number.peso((kvp.Value/100).ToString()) };
                ListViewItem i = new ListViewItem(values);
                this.settleCheckForm.lvTenders.Items.Add(i);
               // balance = (decimal.Parse(balance) -  kvp.Value).ToString();
            }
            this.settleCheckForm.lvTenders.Refresh();
            this.updateBalance();
        }
        public void updateBalance()
        {
            balance = amountDue;
            if (null != usedTenders)
            {
                foreach (KeyValuePair<Media, decimal> kvp in usedTenders)
                {
                    balance = (decimal.Parse(balance) - kvp.Value).ToString();
                }
            }
            this.settleCheckForm.txtBalance.Text = Util.Number.peso((decimal.Parse(balance) / 100).ToString());
            if (balance == "0" || balance.Contains("-"))
                this.finalizeSale();
        }
        private void saveTender(string mediaIndex, decimal amount)
        {
            Media media = mediaList[int.Parse(mediaIndex)];
            MessageBox.Show(string.Format("save tender: {0} : {1}", media.MediaName, amount.ToString()));
            
        }

        public void reset()
        {
            this.settleCheckForm.lvTenders.Items.Clear();
            balance = amountDue;
            usedTenders = null;
            this.updateBalance();
            tenderAmountStr = "";
            this.settleCheckForm.txtTenderAmount.Text = "";
        }

        private void finalizeSale()
        {
            Media lastMedia = null;
            string message = "Check #" + settleCheckForm.csSale.CheckNo + " successfully settled.";
            foreach (KeyValuePair<Media, decimal> kvp in usedTenders)
            {
                lastMedia = kvp.Key;
            }
            if (balance.Contains("-"))
            {//has change
                if (usedTenders.ContainsKey(mediaList[0]))//TODO: otalusan: map cash in configurations
                {//has Cash tender
                    decimal changeDue = decimal.Parse(balance.Replace("-", "")) / 100;
                    decimal cashAmount = usedTenders[mediaList[0]] / 100;
                    if (changeDue > cashAmount)
                    {
                        changeDue = cashAmount;
                        usedTenders.Remove(mediaList[0]);
                    }
                    message += Environment.NewLine + "Change due: " + Util.Number.peso(changeDue.ToString());
                }
                else
                {
                    //no change to be returned
                }
            }
            GenericDialogForm genericDialogForm = new GenericDialogForm();
            genericDialogForm.showGenericDialog(message, GenericDialogForm.Types.OK, 18, "Settle");
            string result = genericDialogForm.consumeResult();
            this.settleCheckForm.Close();
        }

    }
}
