namespace CSFPOSWare.Forms
{
    partial class GenericDialogForm
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
            this.MessageLabel = new System.Windows.Forms.Label();
            this.NoButton = new System.Windows.Forms.Button();
            this.YESButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.Location = new System.Drawing.Point(12, 32);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(441, 123);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "[MESSAGE]";
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NoButton
            // 
            this.NoButton.BackColor = System.Drawing.Color.LightBlue;
            this.NoButton.BackgroundImage = global::CSFPOSWare.Properties.Resources.btn_x;
            this.NoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NoButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.NoButton.FlatAppearance.BorderSize = 0;
            this.NoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.NoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.NoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NoButton.Location = new System.Drawing.Point(241, 182);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(70, 68);
            this.NoButton.TabIndex = 55;
            this.NoButton.UseVisualStyleBackColor = false;
            this.NoButton.Visible = false;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // YESButton
            // 
            this.YESButton.BackColor = System.Drawing.Color.LightBlue;
            this.YESButton.BackgroundImage = global::CSFPOSWare.Properties.Resources.btn_check;
            this.YESButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.YESButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.YESButton.FlatAppearance.BorderSize = 0;
            this.YESButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.YESButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.YESButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YESButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YESButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.YESButton.Location = new System.Drawing.Point(156, 181);
            this.YESButton.Name = "YESButton";
            this.YESButton.Size = new System.Drawing.Size(70, 68);
            this.YESButton.TabIndex = 54;
            this.YESButton.UseVisualStyleBackColor = false;
            this.YESButton.Visible = false;
            this.YESButton.Click += new System.EventHandler(this.YESButton_Click);
            // 
            // GenericDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 261);
            this.ControlBox = false;
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YESButton);
            this.Controls.Add(this.MessageLabel);
            this.Name = "GenericDialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "[TITLE]";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GenericDialogForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
        internal System.Windows.Forms.Button YESButton;
        internal System.Windows.Forms.Button NoButton;
    }
}