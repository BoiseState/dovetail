namespace Dovetail.Displays.SprayBooth
{
    partial class SprayBoothOverviewControl
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.currentJobsListBox = new System.Windows.Forms.ListBox();
            this.jobsInProgressLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.totalPartsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dailySummaryPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.business_BoothTableAdapter1 = new Dovetail._dovetail_dbDataSetTableAdapters.Business_BoothTableAdapter();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.dailySummaryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(349, 664);
            this.panel6.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(359, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 664);
            this.panel1.TabIndex = 4;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerLabel.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(352, 41);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "OVERVIEW                       ";
            // 
            // currentJobsListBox
            // 
            this.currentJobsListBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.currentJobsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentJobsListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.currentJobsListBox.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentJobsListBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.currentJobsListBox.FormattingEnabled = true;
            this.currentJobsListBox.ItemHeight = 24;
            this.currentJobsListBox.Items.AddRange(new object[] {
            "McPhearson",
            "Smith"});
            this.currentJobsListBox.Location = new System.Drawing.Point(0, 119);
            this.currentJobsListBox.Name = "currentJobsListBox";
            this.currentJobsListBox.Size = new System.Drawing.Size(357, 2);
            this.currentJobsListBox.TabIndex = 2;
            this.currentJobsListBox.SelectedIndexChanged += new System.EventHandler(this.currentJobsListBox_SelectedIndexChanged);
            // 
            // jobsInProgressLabel
            // 
            this.jobsInProgressLabel.AutoSize = true;
            this.jobsInProgressLabel.BackColor = System.Drawing.Color.Transparent;
            this.jobsInProgressLabel.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobsInProgressLabel.ForeColor = System.Drawing.Color.Yellow;
            this.jobsInProgressLabel.Location = new System.Drawing.Point(198, 17);
            this.jobsInProgressLabel.Name = "jobsInProgressLabel";
            this.jobsInProgressLabel.Size = new System.Drawing.Size(0, 33);
            this.jobsInProgressLabel.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(2, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "TODAY\'S DATE:";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.currentJobsListBox);
            this.panel5.Controls.Add(this.jobsInProgressLabel);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(359, 123);
            this.panel5.TabIndex = 3;
            // 
            // totalPartsLabel
            // 
            this.totalPartsLabel.AutoSize = true;
            this.totalPartsLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalPartsLabel.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPartsLabel.ForeColor = System.Drawing.Color.Yellow;
            this.totalPartsLabel.Location = new System.Drawing.Point(293, 40);
            this.totalPartsLabel.Name = "totalPartsLabel";
            this.totalPartsLabel.Size = new System.Drawing.Size(43, 33);
            this.totalPartsLabel.TabIndex = 1;
            this.totalPartsLabel.Text = "15";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL HOURS: ";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(359, 106);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(293, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "13";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "NUMBER OF PARTS: ";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.totalPartsLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 270);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(359, 106);
            this.panel4.TabIndex = 2;
            // 
            // dailySummaryPanel
            // 
            this.dailySummaryPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dailySummaryPanel.Controls.Add(this.panel4);
            this.dailySummaryPanel.Controls.Add(this.panel3);
            this.dailySummaryPanel.Controls.Add(this.panel5);
            this.dailySummaryPanel.Controls.Add(this.headerLabel);
            this.dailySummaryPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dailySummaryPanel.Location = new System.Drawing.Point(0, 0);
            this.dailySummaryPanel.Name = "dailySummaryPanel";
            this.dailySummaryPanel.Size = new System.Drawing.Size(359, 664);
            this.dailySummaryPanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(967, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 664);
            this.panel2.TabIndex = 5;
            // 
            // business_BoothTableAdapter1
            // 
            this.business_BoothTableAdapter1.ClearBeforeFill = true;
            // 
            // SprayBoothOverviewControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dailySummaryPanel);
            this.Controls.Add(this.panel2);
            this.Name = "SprayBoothOverviewControl";
            this.Size = new System.Drawing.Size(1115, 664);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.dailySummaryPanel.ResumeLayout(false);
            this.dailySummaryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ListBox currentJobsListBox;
        private System.Windows.Forms.Label jobsInProgressLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label totalPartsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel dailySummaryPanel;
        private System.Windows.Forms.Panel panel2;
        private _dovetail_dbDataSetTableAdapters.Business_BoothTableAdapter business_BoothTableAdapter1;
    }
}
