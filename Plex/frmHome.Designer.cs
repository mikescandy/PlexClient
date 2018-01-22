namespace Plex
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.LboxServers = new System.Windows.Forms.ListBox();
            this.BtnServerSelect = new System.Windows.Forms.Button();
            this.GbServers = new System.Windows.Forms.GroupBox();
            this.LboxLibraries = new System.Windows.Forms.ListBox();
            this.BtnLibrarySelect = new System.Windows.Forms.Button();
            this.GbLibraries = new System.Windows.Forms.GroupBox();
            this.BtnLibraryBackToServer = new System.Windows.Forms.Button();
            this.GbServers.SuspendLayout();
            this.GbLibraries.SuspendLayout();
            this.SuspendLayout();
            // 
            // LboxServers
            // 
            this.LboxServers.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.LboxServers.ForeColor = System.Drawing.Color.Black;
            this.LboxServers.FormattingEnabled = true;
            this.LboxServers.ItemHeight = 16;
            this.LboxServers.Items.AddRange(new object[] {
            "Servers"});
            this.LboxServers.Location = new System.Drawing.Point(0, 30);
            this.LboxServers.Margin = new System.Windows.Forms.Padding(2);
            this.LboxServers.Name = "LboxServers";
            this.LboxServers.Size = new System.Drawing.Size(100, 404);
            this.LboxServers.TabIndex = 3;
            // 
            // BtnServerSelect
            // 
            this.BtnServerSelect.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnServerSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnServerSelect.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.BtnServerSelect.ForeColor = System.Drawing.Color.Black;
            this.BtnServerSelect.Location = new System.Drawing.Point(0, 443);
            this.BtnServerSelect.Name = "BtnServerSelect";
            this.BtnServerSelect.Size = new System.Drawing.Size(100, 35);
            this.BtnServerSelect.TabIndex = 4;
            this.BtnServerSelect.Text = "Select";
            this.BtnServerSelect.UseVisualStyleBackColor = false;
            this.BtnServerSelect.Click += new System.EventHandler(this.BtnServerSelect_Click);
            // 
            // GbServers
            // 
            this.GbServers.BackColor = System.Drawing.Color.Transparent;
            this.GbServers.Controls.Add(this.BtnServerSelect);
            this.GbServers.Controls.Add(this.LboxServers);
            this.GbServers.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Bold);
            this.GbServers.ForeColor = System.Drawing.Color.White;
            this.GbServers.Location = new System.Drawing.Point(11, 11);
            this.GbServers.Margin = new System.Windows.Forms.Padding(2);
            this.GbServers.Name = "GbServers";
            this.GbServers.Padding = new System.Windows.Forms.Padding(2);
            this.GbServers.Size = new System.Drawing.Size(100, 480);
            this.GbServers.TabIndex = 5;
            this.GbServers.TabStop = false;
            this.GbServers.Text = "Servers";
            // 
            // LboxLibraries
            // 
            this.LboxLibraries.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.LboxLibraries.ForeColor = System.Drawing.Color.Black;
            this.LboxLibraries.FormattingEnabled = true;
            this.LboxLibraries.ItemHeight = 16;
            this.LboxLibraries.Items.AddRange(new object[] {
            "Libraries"});
            this.LboxLibraries.Location = new System.Drawing.Point(0, 30);
            this.LboxLibraries.Margin = new System.Windows.Forms.Padding(2);
            this.LboxLibraries.Name = "LboxLibraries";
            this.LboxLibraries.Size = new System.Drawing.Size(100, 404);
            this.LboxLibraries.TabIndex = 1;
            // 
            // BtnLibrarySelect
            // 
            this.BtnLibrarySelect.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnLibrarySelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLibrarySelect.Font = new System.Drawing.Font("Source Sans Pro", 12F);
            this.BtnLibrarySelect.ForeColor = System.Drawing.Color.Black;
            this.BtnLibrarySelect.Location = new System.Drawing.Point(0, 443);
            this.BtnLibrarySelect.Name = "BtnLibrarySelect";
            this.BtnLibrarySelect.Size = new System.Drawing.Size(100, 35);
            this.BtnLibrarySelect.TabIndex = 5;
            this.BtnLibrarySelect.Text = "Select";
            this.BtnLibrarySelect.UseVisualStyleBackColor = false;
            this.BtnLibrarySelect.Click += new System.EventHandler(this.BtnLibrarySelect_Click);
            // 
            // GbLibraries
            // 
            this.GbLibraries.BackColor = System.Drawing.Color.Transparent;
            this.GbLibraries.Controls.Add(this.BtnLibrarySelect);
            this.GbLibraries.Controls.Add(this.LboxLibraries);
            this.GbLibraries.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Bold);
            this.GbLibraries.ForeColor = System.Drawing.Color.White;
            this.GbLibraries.Location = new System.Drawing.Point(151, 11);
            this.GbLibraries.Margin = new System.Windows.Forms.Padding(2);
            this.GbLibraries.Name = "GbLibraries";
            this.GbLibraries.Padding = new System.Windows.Forms.Padding(2);
            this.GbLibraries.Size = new System.Drawing.Size(100, 480);
            this.GbLibraries.TabIndex = 6;
            this.GbLibraries.TabStop = false;
            this.GbLibraries.Text = "Libraries";
            this.GbLibraries.Visible = false;
            // 
            // BtnLibraryBackToServer
            // 
            this.BtnLibraryBackToServer.BackColor = System.Drawing.SystemColors.Control;
            this.BtnLibraryBackToServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLibraryBackToServer.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Bold);
            this.BtnLibraryBackToServer.Location = new System.Drawing.Point(116, 454);
            this.BtnLibraryBackToServer.Name = "BtnLibraryBackToServer";
            this.BtnLibraryBackToServer.Size = new System.Drawing.Size(30, 35);
            this.BtnLibraryBackToServer.TabIndex = 7;
            this.BtnLibraryBackToServer.Text = "<";
            this.BtnLibraryBackToServer.UseVisualStyleBackColor = false;
            this.BtnLibraryBackToServer.Visible = false;
            this.BtnLibraryBackToServer.Click += new System.EventHandler(this.BtnLibraryBackToServer_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.BtnLibraryBackToServer);
            this.Controls.Add(this.GbLibraries);
            this.Controls.Add(this.GbServers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plex Home";
            this.GbServers.ResumeLayout(false);
            this.GbLibraries.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LboxServers;
        private System.Windows.Forms.Button BtnServerSelect;
        private System.Windows.Forms.GroupBox GbServers;
        private System.Windows.Forms.ListBox LboxLibraries;
        private System.Windows.Forms.Button BtnLibrarySelect;
        private System.Windows.Forms.GroupBox GbLibraries;
        private System.Windows.Forms.Button BtnLibraryBackToServer;
    }
}