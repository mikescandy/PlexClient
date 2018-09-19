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
			this.cbServers = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.LBoxLibraries = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.LBoxSub1 = new System.Windows.Forms.ListBox();
			this.panelSub1 = new System.Windows.Forms.Panel();
			this.lblSub1 = new System.Windows.Forms.Label();
			this.panelSub1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbServers
			// 
			this.cbServers.FormattingEnabled = true;
			this.cbServers.Location = new System.Drawing.Point(12, 38);
			this.cbServers.Name = "cbServers";
			this.cbServers.Size = new System.Drawing.Size(218, 21);
			this.cbServers.TabIndex = 0;
			this.cbServers.SelectedIndexChanged += new System.EventHandler(this.cbServers_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Server";
			// 
			// LBoxLibraries
			// 
			this.LBoxLibraries.FormattingEnabled = true;
			this.LBoxLibraries.Location = new System.Drawing.Point(12, 104);
			this.LBoxLibraries.Name = "LBoxLibraries";
			this.LBoxLibraries.Size = new System.Drawing.Size(120, 381);
			this.LBoxLibraries.TabIndex = 2;
			this.LBoxLibraries.SelectedIndexChanged += new System.EventHandler(this.LBoxLibraries_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Libraries";
			// 
			// LBoxSub1
			// 
			this.LBoxSub1.FormattingEnabled = true;
			this.LBoxSub1.Location = new System.Drawing.Point(0, 16);
			this.LBoxSub1.Name = "LBoxSub1";
			this.LBoxSub1.Size = new System.Drawing.Size(120, 381);
			this.LBoxSub1.TabIndex = 4;
			this.LBoxSub1.SelectedIndexChanged += new System.EventHandler(this.LBoxSub1_SelectedIndexChanged);
			// 
			// panelSub1
			// 
			this.panelSub1.Controls.Add(this.lblSub1);
			this.panelSub1.Controls.Add(this.LBoxSub1);
			this.panelSub1.Location = new System.Drawing.Point(138, 89);
			this.panelSub1.Name = "panelSub1";
			this.panelSub1.Size = new System.Drawing.Size(124, 400);
			this.panelSub1.TabIndex = 5;
			this.panelSub1.Visible = false;
			// 
			// lblSub1
			// 
			this.lblSub1.AutoSize = true;
			this.lblSub1.Location = new System.Drawing.Point(3, 0);
			this.lblSub1.Name = "lblSub1";
			this.lblSub1.Size = new System.Drawing.Size(0, 13);
			this.lblSub1.TabIndex = 6;
			// 
			// FrmHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(944, 501);
			this.Controls.Add(this.panelSub1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.LBoxLibraries);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbServers);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "FrmHome";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Plex Home";
			this.panelSub1.ResumeLayout(false);
			this.panelSub1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.ComboBox cbServers;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox LBoxLibraries;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox LBoxSub1;
		private System.Windows.Forms.Panel panelSub1;
		private System.Windows.Forms.Label lblSub1;
	}
}