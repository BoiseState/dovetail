namespace Dovetail.Displays.SprayBooth
{
    partial class SprayBoothMainControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SprayBoothMainControl));
            this.overviewButton = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.navPanel = new System.Windows.Forms.Panel();
            this.historyButton = new System.Windows.Forms.Button();
            this.dailyStatsButton = new System.Windows.Forms.Button();
            this.bufferPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sprayBoothOverviewControl1 = new Dovetail.Displays.SprayBooth.SprayBoothOverviewControl();
            this.headerPanel.SuspendLayout();
            this.navPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // overviewButton
            // 
            this.overviewButton.BackColor = System.Drawing.Color.Transparent;
            this.overviewButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.overviewButton.FlatAppearance.BorderSize = 0;
            this.overviewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.overviewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.overviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overviewButton.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overviewButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.overviewButton.Location = new System.Drawing.Point(0, 0);
            this.overviewButton.Name = "overviewButton";
            this.overviewButton.Size = new System.Drawing.Size(99, 63);
            this.overviewButton.TabIndex = 0;
            this.overviewButton.Text = "Overview";
            this.overviewButton.UseVisualStyleBackColor = false;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.Control;
            this.headerPanel.Controls.Add(this.navPanel);
            this.headerPanel.Controls.Add(this.pictureBox1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1123, 63);
            this.headerPanel.TabIndex = 3;
            // 
            // navPanel
            // 
            this.navPanel.Controls.Add(this.historyButton);
            this.navPanel.Controls.Add(this.dailyStatsButton);
            this.navPanel.Controls.Add(this.overviewButton);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPanel.Location = new System.Drawing.Point(99, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(1090, 63);
            this.navPanel.TabIndex = 0;
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.Color.Transparent;
            this.historyButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.historyButton.FlatAppearance.BorderSize = 0;
            this.historyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.historyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.historyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyButton.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.historyButton.Location = new System.Drawing.Point(198, 0);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(99, 63);
            this.historyButton.TabIndex = 2;
            this.historyButton.Text = "History";
            this.historyButton.UseVisualStyleBackColor = false;
            // 
            // dailyStatsButton
            // 
            this.dailyStatsButton.BackColor = System.Drawing.Color.Transparent;
            this.dailyStatsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.dailyStatsButton.FlatAppearance.BorderSize = 0;
            this.dailyStatsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.dailyStatsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.dailyStatsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dailyStatsButton.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyStatsButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dailyStatsButton.Location = new System.Drawing.Point(99, 0);
            this.dailyStatsButton.Name = "dailyStatsButton";
            this.dailyStatsButton.Size = new System.Drawing.Size(99, 63);
            this.dailyStatsButton.TabIndex = 1;
            this.dailyStatsButton.Text = "Daily Stats";
            this.dailyStatsButton.UseVisualStyleBackColor = false;
            // 
            // bufferPanel
            // 
            this.bufferPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.bufferPanel.Location = new System.Drawing.Point(0, 63);
            this.bufferPanel.Name = "bufferPanel";
            this.bufferPanel.Size = new System.Drawing.Size(99, 580);
            this.bufferPanel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // sprayBoothOverviewControl1
            // 
            this.sprayBoothOverviewControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.sprayBoothOverviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sprayBoothOverviewControl1.Location = new System.Drawing.Point(99, 63);
            this.sprayBoothOverviewControl1.Name = "sprayBoothOverviewControl1";
            this.sprayBoothOverviewControl1.Size = new System.Drawing.Size(1024, 580);
            this.sprayBoothOverviewControl1.TabIndex = 5;
            // 
            // SprayBoothMainControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.sprayBoothOverviewControl1);
            this.Controls.Add(this.bufferPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "SprayBoothMainControl";
            this.Size = new System.Drawing.Size(1123, 643);
            this.headerPanel.ResumeLayout(false);
            this.navPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button overviewButton;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button dailyStatsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel bufferPanel;
        private SprayBoothOverviewControl sprayBoothOverviewControl1;
    }
}
