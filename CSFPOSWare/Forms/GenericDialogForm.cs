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
    public partial class GenericDialogForm : Form
    {
        private string result = null;

        public GenericDialogForm()
        {
            InitializeComponent();

        }

        private void GenericDialogForm_Load(object sender, EventArgs e)
        {

        }

        public void showGenericDialog(string message, string type, int fontSize = 18, string title = "Future POS")
        {
            this.Text = title;
            Font font = new Font("Arial", fontSize, FontStyle.Regular);
            this.MessageLabel.Font = font;
            this.MessageLabel.Text = message;

            int offset = 110;
            if(type == GenericDialogForm.Types.OK)
            {
                this.YESButton.Visible = true;
                //Point p = new Point(OKButton.Location.X - offset, OKButton.Location.Y);
                Point p = new Point(YESButton.Location.X + YESButton.Width/2, YESButton.Location.Y);
                this.YESButton.Location = p;
            }
            else if (type == GenericDialogForm.Types.YES_NO)
            {
                //Point okPoint = new Point(this.OKButton.Location.X + offset / 2, this.OKButton.Location.Y);
                //this.OKButton.Location = okPoint;
                this.YESButton.Visible = true;

                //Point noPoint = new Point(this.NoButton.Location.X + offset / 2, this.NoButton.Location.Y);
                //this.NoButton.Location = noPoint;
                this.NoButton.Visible = true;
            }
            this.ShowDialog();
        }

        public class Types
        {
            public static string OK = "OK";
            public static string YES_NO = "YES_NO";
        }

        public class Results
        {
            public static string YES = "YES";
            public static string NO = "NO";
        }

        private void YESButton_Click(object sender, EventArgs e)
        {
            result = GenericDialogForm.Results.YES;
            this.Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            result = GenericDialogForm.Results.NO;
            this.Close();
        }

        public string consumeResult()
        {
            string r = this.result;
            result = null;
            return r;
        }
    }
}
