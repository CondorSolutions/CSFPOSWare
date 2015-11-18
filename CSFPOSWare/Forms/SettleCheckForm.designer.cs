namespace CSFPOSWare.Forms
{
    partial class SettleCheckForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettleCheckForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblCheckNo = new System.Windows.Forms.Label();
            this.Bill5 = new System.Windows.Forms.Button();
            this.Bill20 = new System.Windows.Forms.Button();
            this.Bill1000 = new System.Windows.Forms.Button();
            this.Bill500 = new System.Windows.Forms.Button();
            this.Bill100 = new System.Windows.Forms.Button();
            this.Bill50 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.ClearTenderAmountButton = new System.Windows.Forms.Button();
            this.BackspaceButton = new System.Windows.Forms.Button();
            this.Button12 = new System.Windows.Forms.Button();
            this.Button11 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.lvTenders = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtTenderAmount = new System.Windows.Forms.TextBox();
            this.lblTenderAmount = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblAmountDue);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.lblCheckNo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 31);
            this.panel1.TabIndex = 5;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAmountDue.Location = new System.Drawing.Point(616, 2);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(94, 26);
            this.lblAmountDue.TabIndex = 9;
            this.lblAmountDue.Text = "P 00.00";
            this.lblAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label2.Location = new System.Drawing.Point(495, 7);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(103, 20);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Amount Due:";
            // 
            // lblCheckNo
            // 
            this.lblCheckNo.AutoSize = true;
            this.lblCheckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCheckNo.Location = new System.Drawing.Point(27, 4);
            this.lblCheckNo.Name = "lblCheckNo";
            this.lblCheckNo.Size = new System.Drawing.Size(43, 24);
            this.lblCheckNo.TabIndex = 7;
            this.lblCheckNo.Text = "000";
            // 
            // Bill5
            // 
            this.Bill5.BackColor = System.Drawing.Color.LightBlue;
            this.Bill5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bill5.BackgroundImage")));
            this.Bill5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bill5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Bill5.FlatAppearance.BorderSize = 0;
            this.Bill5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Bill5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.Bill5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bill5.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bill5.Location = new System.Drawing.Point(21, 50);
            this.Bill5.Name = "Bill5";
            this.Bill5.Size = new System.Drawing.Size(215, 76);
            this.Bill5.TabIndex = 49;
            this.Bill5.Text = "₱5";
            this.Bill5.UseVisualStyleBackColor = false;
            this.Bill5.Click += new System.EventHandler(this.BillsButton_Click);
            this.Bill5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseDown);
            this.Bill5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseUp);
            // 
            // Bill20
            // 
            this.Bill20.BackColor = System.Drawing.Color.LightBlue;
            this.Bill20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bill20.BackgroundImage")));
            this.Bill20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bill20.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Bill20.FlatAppearance.BorderSize = 0;
            this.Bill20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Bill20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.Bill20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bill20.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bill20.Location = new System.Drawing.Point(21, 132);
            this.Bill20.Name = "Bill20";
            this.Bill20.Size = new System.Drawing.Size(215, 76);
            this.Bill20.TabIndex = 48;
            this.Bill20.Text = "₱20";
            this.Bill20.UseVisualStyleBackColor = false;
            this.Bill20.Click += new System.EventHandler(this.BillsButton_Click);
            // 
            // Bill1000
            // 
            this.Bill1000.BackColor = System.Drawing.Color.LightBlue;
            this.Bill1000.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bill1000.BackgroundImage")));
            this.Bill1000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bill1000.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Bill1000.FlatAppearance.BorderSize = 0;
            this.Bill1000.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Bill1000.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.Bill1000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bill1000.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill1000.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bill1000.Location = new System.Drawing.Point(21, 460);
            this.Bill1000.Name = "Bill1000";
            this.Bill1000.Size = new System.Drawing.Size(215, 76);
            this.Bill1000.TabIndex = 47;
            this.Bill1000.Text = "₱1000";
            this.Bill1000.UseVisualStyleBackColor = false;
            this.Bill1000.Click += new System.EventHandler(this.BillsButton_Click);
            // 
            // Bill500
            // 
            this.Bill500.BackColor = System.Drawing.Color.LightBlue;
            this.Bill500.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bill500.BackgroundImage")));
            this.Bill500.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bill500.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Bill500.FlatAppearance.BorderSize = 0;
            this.Bill500.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Bill500.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.Bill500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bill500.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill500.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bill500.Location = new System.Drawing.Point(21, 378);
            this.Bill500.Name = "Bill500";
            this.Bill500.Size = new System.Drawing.Size(215, 76);
            this.Bill500.TabIndex = 46;
            this.Bill500.Text = "₱500";
            this.Bill500.UseVisualStyleBackColor = false;
            this.Bill500.Click += new System.EventHandler(this.BillsButton_Click);
            // 
            // Bill100
            // 
            this.Bill100.BackColor = System.Drawing.Color.LightBlue;
            this.Bill100.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bill100.BackgroundImage")));
            this.Bill100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bill100.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Bill100.FlatAppearance.BorderSize = 0;
            this.Bill100.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Bill100.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.Bill100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bill100.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill100.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bill100.Location = new System.Drawing.Point(21, 296);
            this.Bill100.Name = "Bill100";
            this.Bill100.Size = new System.Drawing.Size(215, 76);
            this.Bill100.TabIndex = 45;
            this.Bill100.Text = "₱100";
            this.Bill100.UseVisualStyleBackColor = false;
            this.Bill100.Click += new System.EventHandler(this.BillsButton_Click);
            // 
            // Bill50
            // 
            this.Bill50.BackColor = System.Drawing.Color.LightBlue;
            this.Bill50.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bill50.BackgroundImage")));
            this.Bill50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bill50.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Bill50.FlatAppearance.BorderSize = 0;
            this.Bill50.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Bill50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.Bill50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bill50.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill50.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bill50.Location = new System.Drawing.Point(21, 214);
            this.Bill50.Name = "Bill50";
            this.Bill50.Size = new System.Drawing.Size(215, 76);
            this.Bill50.TabIndex = 44;
            this.Bill50.Text = "₱50";
            this.Bill50.UseVisualStyleBackColor = false;
            this.Bill50.Click += new System.EventHandler(this.BillsButton_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightBlue;
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(495, 497);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 44);
            this.btnReset.TabIndex = 70;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseDown);
            this.btnReset.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseUp);
            // 
            // ClearTenderAmountButton
            // 
            this.ClearTenderAmountButton.BackColor = System.Drawing.Color.LightBlue;
            this.ClearTenderAmountButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearTenderAmountButton.BackgroundImage")));
            this.ClearTenderAmountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearTenderAmountButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ClearTenderAmountButton.FlatAppearance.BorderSize = 0;
            this.ClearTenderAmountButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.ClearTenderAmountButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.ClearTenderAmountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearTenderAmountButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearTenderAmountButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClearTenderAmountButton.Location = new System.Drawing.Point(447, 58);
            this.ClearTenderAmountButton.Name = "ClearTenderAmountButton";
            this.ClearTenderAmountButton.Size = new System.Drawing.Size(42, 32);
            this.ClearTenderAmountButton.TabIndex = 68;
            this.ClearTenderAmountButton.Text = "X";
            this.ClearTenderAmountButton.UseVisualStyleBackColor = false;
            this.ClearTenderAmountButton.Click += new System.EventHandler(this.ClearTenderAmountButton_Click);
            this.ClearTenderAmountButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseDown);
            this.ClearTenderAmountButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseUp);
            // 
            // BackspaceButton
            // 
            this.BackspaceButton.BackColor = System.Drawing.Color.LightBlue;
            this.BackspaceButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackspaceButton.BackgroundImage")));
            this.BackspaceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackspaceButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BackspaceButton.FlatAppearance.BorderSize = 0;
            this.BackspaceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BackspaceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.BackspaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackspaceButton.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackspaceButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackspaceButton.Location = new System.Drawing.Point(267, 302);
            this.BackspaceButton.Name = "BackspaceButton";
            this.BackspaceButton.Size = new System.Drawing.Size(70, 60);
            this.BackspaceButton.TabIndex = 67;
            this.BackspaceButton.Text = "<";
            this.BackspaceButton.UseVisualStyleBackColor = false;
            this.BackspaceButton.Click += new System.EventHandler(this.BackspaceButton_Click);
            this.BackspaceButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseDown);
            this.BackspaceButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseUp);
            // 
            // Button12
            // 
            this.Button12.BackColor = System.Drawing.Color.LightBlue;
            this.Button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button12.BackgroundImage")));
            this.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button12.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button12.FlatAppearance.BorderSize = 0;
            this.Button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button12.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button12.Location = new System.Drawing.Point(419, 302);
            this.Button12.Name = "Button12";
            this.Button12.Size = new System.Drawing.Size(70, 60);
            this.Button12.TabIndex = 66;
            this.Button12.Text = "00";
            this.Button12.UseVisualStyleBackColor = false;
            this.Button12.Click += new System.EventHandler(this.NumberButtons_Click);
            this.Button12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseDown);
            this.Button12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseUp);
            // 
            // Button11
            // 
            this.Button11.BackColor = System.Drawing.Color.LightBlue;
            this.Button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button11.BackgroundImage")));
            this.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button11.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button11.FlatAppearance.BorderSize = 0;
            this.Button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button11.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button11.Location = new System.Drawing.Point(343, 302);
            this.Button11.Name = "Button11";
            this.Button11.Size = new System.Drawing.Size(70, 60);
            this.Button11.TabIndex = 65;
            this.Button11.Text = "0";
            this.Button11.UseVisualStyleBackColor = false;
            this.Button11.Click += new System.EventHandler(this.NumberButtons_Click);
            this.Button11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseDown);
            this.Button11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseUp);
            // 
            // Button9
            // 
            this.Button9.BackColor = System.Drawing.Color.LightBlue;
            this.Button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button9.BackgroundImage")));
            this.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button9.FlatAppearance.BorderSize = 0;
            this.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button9.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button9.Location = new System.Drawing.Point(419, 236);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(70, 60);
            this.Button9.TabIndex = 64;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = false;
            this.Button9.Click += new System.EventHandler(this.NumberButtons_Click);
            this.Button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseDown);
            this.Button9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseUp);
            // 
            // Button8
            // 
            this.Button8.BackColor = System.Drawing.Color.LightBlue;
            this.Button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button8.BackgroundImage")));
            this.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button8.FlatAppearance.BorderSize = 0;
            this.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button8.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button8.Location = new System.Drawing.Point(343, 236);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(70, 60);
            this.Button8.TabIndex = 63;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = false;
            this.Button8.Click += new System.EventHandler(this.NumberButtons_Click);
            this.Button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseDown);
            this.Button8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseUp);
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.Color.LightBlue;
            this.Button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button7.BackgroundImage")));
            this.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button7.FlatAppearance.BorderSize = 0;
            this.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button7.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button7.Location = new System.Drawing.Point(267, 236);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(70, 60);
            this.Button7.TabIndex = 62;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.NumberButtons_Click);
            this.Button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseDown);
            this.Button7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseUp);
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.LightBlue;
            this.Button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button6.BackgroundImage")));
            this.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button6.FlatAppearance.BorderSize = 0;
            this.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button6.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button6.Location = new System.Drawing.Point(419, 170);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(70, 60);
            this.Button6.TabIndex = 61;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.NumberButtons_Click);
            this.Button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseDown);
            this.Button6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseUp);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.LightBlue;
            this.Button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button5.BackgroundImage")));
            this.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button5.FlatAppearance.BorderSize = 0;
            this.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button5.Location = new System.Drawing.Point(343, 170);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(70, 60);
            this.Button5.TabIndex = 60;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.NumberButtons_Click);
            this.Button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseDown);
            this.Button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseUp);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.LightBlue;
            this.Button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button4.BackgroundImage")));
            this.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button4.FlatAppearance.BorderSize = 0;
            this.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button4.Location = new System.Drawing.Point(267, 170);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(70, 60);
            this.Button4.TabIndex = 59;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.NumberButtons_Click);
            this.Button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseDown);
            this.Button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseUp);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.LightBlue;
            this.Button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button3.BackgroundImage")));
            this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button3.Location = new System.Drawing.Point(419, 104);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(70, 60);
            this.Button3.TabIndex = 58;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.NumberButtons_Click);
            this.Button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseDown);
            this.Button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseUp);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.LightBlue;
            this.Button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button2.BackgroundImage")));
            this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button2.Location = new System.Drawing.Point(343, 104);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(70, 60);
            this.Button2.TabIndex = 57;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.NumberButtons_Click);
            this.Button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseDown);
            this.Button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseUp);
            // 
            // lvTenders
            // 
            this.lvTenders.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lvTenders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvTenders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2});
            this.lvTenders.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTenders.Location = new System.Drawing.Point(266, 393);
            this.lvTenders.Name = "lvTenders";
            this.lvTenders.Size = new System.Drawing.Size(223, 117);
            this.lvTenders.TabIndex = 56;
            this.lvTenders.UseCompatibleStateImageBehavior = false;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Width = 115;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ColumnHeader2.Width = 90;
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(343, 516);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(146, 25);
            this.txtBalance.TabIndex = 55;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(266, 519);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(71, 20);
            this.Label3.TabIndex = 54;
            this.Label3.Text = "Balance:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(262, 372);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(71, 20);
            this.Label1.TabIndex = 53;
            this.Label1.Text = "Tenders:";
            // 
            // txtTenderAmount
            // 
            this.txtTenderAmount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTenderAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenderAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenderAmount.Location = new System.Drawing.Point(267, 61);
            this.txtTenderAmount.MaxLength = 11;
            this.txtTenderAmount.Name = "txtTenderAmount";
            this.txtTenderAmount.ReadOnly = true;
            this.txtTenderAmount.Size = new System.Drawing.Size(174, 25);
            this.txtTenderAmount.TabIndex = 51;
            this.txtTenderAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTenderAmount
            // 
            this.lblTenderAmount.AutoSize = true;
            this.lblTenderAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblTenderAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenderAmount.Location = new System.Drawing.Point(262, 34);
            this.lblTenderAmount.Name = "lblTenderAmount";
            this.lblTenderAmount.Size = new System.Drawing.Size(123, 20);
            this.lblTenderAmount.TabIndex = 50;
            this.lblTenderAmount.Text = "Tender Amount:";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.LightBlue;
            //this.CloseButton.BackgroundImage = global::CSFPOSWareV3.Properties.Resources.ButtonBGBlank;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton.Location = new System.Drawing.Point(686, 489);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(70, 60);
            this.CloseButton.TabIndex = 69;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseDown);
            this.CloseButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseUp);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.LightBlue;
            this.Button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button1.BackgroundImage")));
            this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button1.Location = new System.Drawing.Point(267, 104);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(70, 60);
            this.Button1.TabIndex = 52;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.NumberButtons_Click);
            this.Button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseDown);
            this.Button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Buttons_MouseUp);
            // 
            // SettleCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(771, 560);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ClearTenderAmountButton);
            this.Controls.Add(this.BackspaceButton);
            this.Controls.Add(this.Button12);
            this.Controls.Add(this.Button11);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.lvTenders);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txtTenderAmount);
            this.Controls.Add(this.lblTenderAmount);
            this.Controls.Add(this.Bill5);
            this.Controls.Add(this.Bill20);
            this.Controls.Add(this.Bill1000);
            this.Controls.Add(this.Bill500);
            this.Controls.Add(this.Bill100);
            this.Controls.Add(this.Bill50);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettleCheckForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settle Check #";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettleCheckForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label lblAmountDue;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lblCheckNo;
        internal System.Windows.Forms.Button Bill5;
        internal System.Windows.Forms.Button Bill20;
        internal System.Windows.Forms.Button Bill1000;
        internal System.Windows.Forms.Button Bill500;
        internal System.Windows.Forms.Button Bill100;
        internal System.Windows.Forms.Button Bill50;
        internal System.Windows.Forms.Button btnReset;
        internal System.Windows.Forms.Button CloseButton;
        internal System.Windows.Forms.Button ClearTenderAmountButton;
        internal System.Windows.Forms.Button BackspaceButton;
        internal System.Windows.Forms.Button Button12;
        internal System.Windows.Forms.Button Button11;
        internal System.Windows.Forms.Button Button9;
        internal System.Windows.Forms.Button Button8;
        internal System.Windows.Forms.Button Button7;
        internal System.Windows.Forms.Button Button6;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.ListView lvTenders;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.TextBox txtBalance;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txtTenderAmount;
        internal System.Windows.Forms.Label lblTenderAmount;
    }
}