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
            this.LboxLibraries = new System.Windows.Forms.ListBox();
            this.LboxServers = new System.Windows.Forms.ListBox();
            this.GbServers = new System.Windows.Forms.GroupBox();
            this.GbLibraries = new System.Windows.Forms.GroupBox();
            this.GbServers.SuspendLayout();
            this.GbLibraries.SuspendLayout();
            this.SuspendLayout();
            // 
            // LboxLibraries
            // 
            this.LboxLibraries.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.LboxLibraries.FormattingEnabled = true;
            this.LboxLibraries.ItemHeight = 34;
            this.LboxLibraries.Items.AddRange(new object[] {
            " "});
            this.LboxLibraries.Location = new System.Drawing.Point(6, 31);
            this.LboxLibraries.Name = "LboxLibraries";
            this.LboxLibraries.Size = new System.Drawing.Size(171, 548);
            this.LboxLibraries.TabIndex = 1;
            this.LboxLibraries.Click += new System.EventHandler(this.LboxLibraries_Click);
            // 
            // LboxServers
            // 
            this.LboxServers.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.LboxServers.FormattingEnabled = true;
            this.LboxServers.ItemHeight = 34;
            this.LboxServers.Location = new System.Drawing.Point(6, 31);
            this.LboxServers.Name = "LboxServers";
            this.LboxServers.Size = new System.Drawing.Size(171, 548);
            this.LboxServers.TabIndex = 3;
            this.LboxServers.Click += new System.EventHandler(this.LboxServers_Click);
            this.LboxServers.SelectedIndexChanged += new System.EventHandler(this.LboxServers_SelectedIndexChanged);
            // 
            // GbServers
            // 
            this.GbServers.Controls.Add(this.LboxServers);
            this.GbServers.Font = new System.Drawing.Font("Source Sans Pro", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbServers.Location = new System.Drawing.Point(12, 60);
            this.GbServers.Name = "GbServers";
            this.GbServers.Size = new System.Drawing.Size(182, 585);
            this.GbServers.TabIndex = 5;
            this.GbServers.TabStop = false;
            this.GbServers.Text = "Servers";
            // 
            // GbLibraries
            // 
            this.GbLibraries.Controls.Add(this.LboxLibraries);
            this.GbLibraries.Font = new System.Drawing.Font("Source Sans Pro", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbLibraries.Location = new System.Drawing.Point(200, 60);
            this.GbLibraries.Name = "GbLibraries";
            this.GbLibraries.Size = new System.Drawing.Size(182, 585);
            this.GbLibraries.TabIndex = 6;
            this.GbLibraries.TabStop = false;
            this.GbLibraries.Text = "Libraries";
            this.GbLibraries.Visible = false;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 729);
            this.Controls.Add(this.GbLibraries);
            this.Controls.Add(this.GbServers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plex Home";
            this.GbServers.ResumeLayout(false);
            this.GbLibraries.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox LboxLibraries;
        private System.Windows.Forms.ListBox LboxServers;
        private System.Windows.Forms.GroupBox GbServers;
        private System.Windows.Forms.GroupBox GbLibraries;
    }
}