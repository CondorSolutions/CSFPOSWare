using CSFPOSWare.Models;
using CSFPOSWare.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSFPOSWare.Forms
{
    public partial class SettleCheckForm : Form
    {
        private SettleCheckFormHelper helper = null;
       // List<Button> mediaButtons = null;
        public CSSale csSale = null;
        public SettleCheckForm(CSSale csSale)
        {
            InitializeComponent();
            this.csSale = csSale;
            helper = new SettleCheckFormHelper(this);
        }
       
        private void SettleCheckForm_Load(object sender, EventArgs e)
        {
            //GenericDialogForm genericDialogForm = new GenericDialogForm();
            //genericDialogForm.showGenericDialog("test", GenericDialogForm.Types.YES_NO);
            //string result = genericDialogForm.consumeResult();


            //MessageBox.Show(result);

            foreach (Button mediaButton in helper.loadMediaButtons())
            {
                mediaButton.Click += new EventHandler(MediaButtons_Click);
                mediaButton.MouseDown += new MouseEventHandler(Buttons_MouseDown);
                mediaButton.MouseUp += new MouseEventHandler(Buttons_MouseUp);
                this.Controls.Add(mediaButton);
            }
            lblAmountDue.Text = Util.Number.peso((decimal.Parse(helper.amountDue) / 100).ToString()); 
            lblCheckNo.Text = this.csSale.CheckNo.ToString();
            helper.updateBalance();
        }

        public void MediaButtons_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            helper.useTender(b);
        }

        public void NumberButtons_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            helper.type(b);
        }

        public void Buttons_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            b.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ButtonBGBlankPressed));
        }

        public void Buttons_MouseUp(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            b.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ButtonBGBlank));
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearTenderAmountButton_Click(object sender, EventArgs e)
        {
            helper.clearTenderAmount();
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            helper.backspace();
        }

        private void BillsButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            helper.typeBill(b);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            helper.reset();
        }
    }
}
