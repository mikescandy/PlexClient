namespace Plex
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblUsername = new System.Windows.Forms.Label();
            this.BtnSignin = new System.Windows.Forms.Button();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.PanelSignIn = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.PanelSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtUsername
            // 
            this.TxtUsername.CausesValidation = false;
            this.TxtUsername.Font = new System.Drawing.Font("Source Sans Pro Light", 24F);
            this.TxtUsername.Location = new System.Drawing.Point(343, 41);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(632, 88);
            this.TxtUsername.TabIndex = 0;
            this.TxtUsername.Text = "hunsbct";
            this.TxtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblPassword.CausesValidation = false;
            this.LblPassword.Font = new System.Drawing.Font("Source Sans Pro", 24F);
            this.LblPassword.ForeColor = System.Drawing.Color.Black;
            this.LblPassword.Location = new System.Drawing.Point(30, 153);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(307, 80);
            this.LblPassword.TabIndex = 4;
            this.LblPassword.Text = "Password:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.White;
            this.TxtPassword.CausesValidation = false;
            this.TxtPassword.Font = new System.Drawing.Font("Source Sans Pro Light", 24F);
            this.TxtPassword.Location = new System.Drawing.Point(343, 150);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '•';
            this.TxtPassword.Size = new System.Drawing.Size(632, 88);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.Text = "Wormrot0";
            this.TxtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.BackColor = System.Drawing.Color.Transparent;
            this.LblUsername.CausesValidation = false;
            this.LblUsername.Font = new System.Drawing.Font("Source Sans Pro", 24F);
            this.LblUsername.ForeColor = System.Drawing.Color.Black;
            this.LblUsername.Location = new System.Drawing.Point(13, 44);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(324, 80);
            this.LblUsername.TabIndex = 3;
            this.LblUsername.Text = "Username:";
            // 
            // BtnSignin
            // 
            this.BtnSignin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSignin.Font = new System.Drawing.Font("Source Sans Pro", 24F);
            this.BtnSignin.Location = new System.Drawing.Point(849, 671);
            this.BtnSignin.Name = "BtnSignin";
            this.BtnSignin.Size = new System.Drawing.Size(339, 117);
            this.BtnSignin.TabIndex = 5;
            this.BtnSignin.Text = "Sign In";
            this.BtnSignin.UseVisualStyleBackColor = false;
            this.BtnSignin.Click += new System.EventHandler(this.BtnSignin_Click);
            // 
            // PbLogo
            // 
            this.PbLogo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbLogo.Image")));
            this.PbLogo.Location = new System.Drawing.Point(306, 50);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(588, 230);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbLogo.TabIndex = 6;
            this.PbLogo.TabStop = false;
            // 
            // PanelSignIn
            // 
            this.PanelSignIn.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelSignIn.CausesValidation = false;
            this.PanelSignIn.Controls.Add(this.LblUsername);
            this.PanelSignIn.Controls.Add(this.LblPassword);
            this.PanelSignIn.Controls.Add(this.TxtUsername);
            this.PanelSignIn.Controls.Add(this.TxtPassword);
            this.PanelSignIn.Location = new System.Drawing.Point(100, 340);
            this.PanelSignIn.Name = "PanelSignIn";
            this.PanelSignIn.Size = new System.Drawing.Size(1000, 267);
            this.PanelSignIn.TabIndex = 7;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.DarkGray;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnExit.Font = new System.Drawing.Font("Source Sans Pro", 24F);
            this.BtnExit.Location = new System.Drawing.Point(12, 671);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(339, 117);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.ControlBox = false;
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.PbLogo);
            this.Controls.Add(this.BtnSignin);
            this.Controls.Add(this.PanelSignIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.PanelSignIn.ResumeLayout(false);
            this.PanelSignIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Button BtnSignin;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.Panel PanelSignIn;
        private System.Windows.Forms.Button BtnExit;
    }
}

