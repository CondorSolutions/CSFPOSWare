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
        List<Button> mediaButtons = null;
        public SettleCheckForm(SettleCheckFormHelper settleCheckFormHelper)
        {
            InitializeComponent();
            helper = settleCheckFormHelper;
        }
       
        private void SettleCheckForm_Load(object sender, EventArgs e)
        {
            foreach(Button mediaButton in helper.loadMediaButtons())
            {
                mediaButton.Click += new EventHandler(MediaButtons_Click);
                mediaButton.MouseDown += new MouseEventHandler(Buttons_MouseDown);
                mediaButton.MouseUp += new MouseEventHandler(Buttons_MouseUp);
                this.Controls.Add(mediaButton);
            }

            lblAmountDue.Text = Util.Number.peso((decimal.Parse(helper.amountDue) / 100).ToString()); 
            lblCheckNo.Text = helper.csSale.CheckNo.ToString();
            helper.updateBalance(this);
        }

        public void MediaButtons_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            helper.useTender(b, this);
        }

        public void NumberButtons_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            helper.type(b, this);
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
            helper.clearTenderAmount(this);
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            helper.backspace(this);
        }

        private void BillsButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            helper.typeBill(b, this);
        }
    }
}
