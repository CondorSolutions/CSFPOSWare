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
        public CSSale csSale = null;
        public string amountDue = "55555";
        public string tenderAmountStr = "";
        public string balance = "";
        public SettleCheckFormHelper(CSSale csSale)
        {
            this.csSale = csSale;
            balance = amountDue;
        }

        
        public List<Button> loadMediaButtons()
        {
            MaintenanceDAO maintenanceDAO = new MaintenanceDAO();

            int topMargin = 60;
            int itemLimit = 5;
            int count = 1;
            int left = 520;
            int[] leftButtons = { 0, 3, 6,9,12,15,18 };
            int[] middleButton = { 1, 4, 7, 10, 13, 16 };
            List<Button> mediaButtons = new List<Button>();
            foreach (Media media in maintenanceDAO.getMedia())
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

        public void updateBalance(SettleCheckForm form)
        {
            form.txtBalance.Text = Util.Number.peso((decimal.Parse(balance) / 100).ToString());
        }
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

        public void type(Button b, SettleCheckForm form)
        {
            tenderAmountStr += b.Text;
            form.txtTenderAmount.Text = Util.Number.peso((decimal.Parse(tenderAmountStr)/100).ToString());
        }

        public void typeBill(Button b, SettleCheckForm form)
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
            form.txtTenderAmount.Text = Util.Number.peso((decimal.Parse(tenderAmountStr) / 100).ToString());
        }

        public void clearTenderAmount(SettleCheckForm form)
        {
            tenderAmountStr = "";
            form.txtTenderAmount.Text = tenderAmountStr;
        }

        public void backspace(SettleCheckForm form)
        {
            if (tenderAmountStr.Length > 0)
            {
                tenderAmountStr = tenderAmountStr.Substring(0, tenderAmountStr.Length - 1);
            }
            else
            {
                tenderAmountStr = "";
                form.txtTenderAmount.Text = "";
            }

            if (tenderAmountStr.Length > 0)
            {
                form.txtTenderAmount.Text = Util.Number.peso((decimal.Parse(tenderAmountStr) / 100).ToString());
            }
            else
            {
                form.txtTenderAmount.Text = "";
            }
        }

        Dictionary<Media, string> usedTenders = null;
        public void useTender(Button button, SettleCheckForm form)
        {
            string mediaIndex = button.Name.Replace(mediaButtonPrefix, "");

            if (tenderAmountStr == "")
            {//tender exact
                tenderAmountStr = amountDue;
                balance = "0";
            }


            saveTender(mediaIndex, decimal.Parse(tenderAmountStr)/100);
            updateBalance(form);
            tenderAmountStr = "";
            form.txtTenderAmount.Text ="";

        }

        private void saveTender(string mediaIndex, decimal amount)
        {
            MessageBox.Show(string.Format("save tender: {0} : {1}", mediaIndex, amount.ToString()));
            
        }
    }
}
