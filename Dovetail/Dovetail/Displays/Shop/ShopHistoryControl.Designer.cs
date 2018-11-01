namespace Dovetail.Displays.Shop
{
    partial class ShopHistoryControl
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShopDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalsPanel = new System.Windows.Forms.Panel();
            this.TotalFinishedPartsLabel = new System.Windows.Forms.Label();
            this.TotalDrawersLabel = new System.Windows.Forms.Label();
            this.TotalBoxesLabel = new System.Windows.Forms.Label();
            this.DoorsLabel = new System.Windows.Forms.Label();
            this.EdgBardedLabel = new System.Windows.Forms.Label();
            this.TotalSheetsLabel = new System.Windows.Forms.Label();
            this.TotalHoursLabel = new System.Windows.Forms.Label();
            this.CuttingHoursLabel = new System.Windows.Forms.Label();
            this.EdgeBandingHoursLabel = new System.Windows.Forms.Label();
            this.DrawerHoursLabel = new System.Windows.Forms.Label();
            this.BoxHoursLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ReturnLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.business_ShopTableAdapter1 = new Dovetail._dovetail_dbDataSetTableAdapters.Business_ShopTableAdapter();
            this.jobsDataGridView = new System.Windows.Forms.DataGridView();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.TotalsPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(925, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 820);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "History";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 78);
            this.panel1.TabIndex = 5;
            // 
            // ShopDatePicker
            // 
            this.ShopDatePicker.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopDatePicker.Location = new System.Drawing.Point(128, 113);
            this.ShopDatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.ShopDatePicker.Name = "ShopDatePicker";
            this.ShopDatePicker.Size = new System.Drawing.Size(327, 32);
            this.ShopDatePicker.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(25, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date:";
            // 
            // TotalsPanel
            // 
            this.TotalsPanel.AutoScroll = true;
            this.TotalsPanel.BackColor = System.Drawing.Color.SlateGray;
            this.TotalsPanel.Controls.Add(this.TotalFinishedPartsLabel);
            this.TotalsPanel.Controls.Add(this.TotalDrawersLabel);
            this.TotalsPanel.Controls.Add(this.TotalBoxesLabel);
            this.TotalsPanel.Controls.Add(this.DoorsLabel);
            this.TotalsPanel.Controls.Add(this.EdgBardedLabel);
            this.TotalsPanel.Controls.Add(this.TotalSheetsLabel);
            this.TotalsPanel.Controls.Add(this.TotalHoursLabel);
            this.TotalsPanel.Controls.Add(this.CuttingHoursLabel);
            this.TotalsPanel.Controls.Add(this.EdgeBandingHoursLabel);
            this.TotalsPanel.Controls.Add(this.DrawerHoursLabel);
            this.TotalsPanel.Controls.Add(this.BoxHoursLabel);
            this.TotalsPanel.Controls.Add(this.label12);
            this.TotalsPanel.Controls.Add(this.label13);
            this.TotalsPanel.Controls.Add(this.label14);
            this.TotalsPanel.Controls.Add(this.panel4);
            this.TotalsPanel.Controls.Add(this.label10);
            this.TotalsPanel.Controls.Add(this.label9);
            this.TotalsPanel.Controls.Add(this.label8);
            this.TotalsPanel.Controls.Add(this.label7);
            this.TotalsPanel.Controls.Add(this.label6);
            this.TotalsPanel.Controls.Add(this.label5);
            this.TotalsPanel.Controls.Add(this.label4);
            this.TotalsPanel.Controls.Add(this.label3);
            this.TotalsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TotalsPanel.Location = new System.Drawing.Point(924, 78);
            this.TotalsPanel.Name = "TotalsPanel";
            this.TotalsPanel.Size = new System.Drawing.Size(1, 742);
            this.TotalsPanel.TabIndex = 9;
            this.TotalsPanel.Visible = false;
            // 
            // TotalFinishedPartsLabel
            // 
            this.TotalFinishedPartsLabel.AutoSize = true;
            this.TotalFinishedPartsLabel.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFinishedPartsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalFinishedPartsLabel.Location = new System.Drawing.Point(267, 582);
            this.TotalFinishedPartsLabel.Name = "TotalFinishedPartsLabel";
            this.TotalFinishedPartsLabel.Size = new System.Drawing.Size(43, 29);
            this.TotalFinishedPartsLabel.TabIndex = 27;
            this.TotalFinishedPartsLabel.Text = "0.0";
            // 
            // TotalDrawersLabel
            // 
            this.TotalDrawersLabel.AutoSize = true;
            this.TotalDrawersLabel.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDrawersLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalDrawersLabel.Location = new System.Drawing.Point(267, 537);
            this.TotalDrawersLabel.Name = "TotalDrawersLabel";
            this.TotalDrawersLabel.Size = new System.Drawing.Size(43, 29);
            this.TotalDrawersLabel.TabIndex = 26;
            this.TotalDrawersLabel.Text = "0.0";
            // 
            // TotalBoxesLabel
            // 
            this.TotalBoxesLabel.AutoSize = true;
            this.TotalBoxesLabel.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBoxesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalBoxesLabel.Location = new System.Drawing.Point(267, 492);
            this.TotalBoxesLabel.Name = "TotalBoxesLabel";
            this.TotalBoxesLabel.Size = new System.Drawing.Size(43, 29);
            this.TotalBoxesLabel.TabIndex = 25;
            this.TotalBoxesLabel.Text = "0.0";
            // 
            // DoorsLabel
            // 
            this.DoorsLabel.AutoSize = true;
            this.DoorsLabel.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoorsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DoorsLabel.Location = new System.Drawing.Point(267, 447);
            this.DoorsLabel.Name = "DoorsLabel";
            this.DoorsLabel.Size = new System.Drawing.Size(43, 29);
            this.DoorsLabel.TabIndex = 24;
            this.DoorsLabel.Text = "0.0";
            // 
            // EdgBardedLabel
            // 
            this.EdgBardedLabel.AutoSize = true;
            this.EdgBardedLabel.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdgBardedLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EdgBardedLabel.Location = new System.Drawing.Point(267, 402);
            this.EdgBardedLabel.Name = "EdgBardedLabel";
            this.EdgBardedLabel.Size = new System.Drawing.Size(43, 29);
            this.EdgBardedLabel.TabIndex = 23;
            this.EdgBardedLabel.Text = "0.0";
            // 
            // TotalSheetsLabel
            // 
            this.TotalSheetsLabel.AutoSize = true;
            this.TotalSheetsLabel.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSheetsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalSheetsLabel.Location = new System.Drawing.Point(267, 357);
            this.TotalSheetsLabel.Name = "TotalSheetsLabel";
            this.TotalSheetsLabel.Size = new System.Drawing.Size(43, 29);
            this.TotalSheetsLabel.TabIndex = 22;
            this.TotalSheetsLabel.Text = "0.0";
            // 
            // TotalHoursLabel
            // 
            this.TotalHoursLabel.AutoSize = true;
            this.TotalHoursLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalHoursLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TotalHoursLabel.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalHoursLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalHoursLabel.Location = new System.Drawing.Point(265, 32);
            this.TotalHoursLabel.Name = "TotalHoursLabel";
            this.TotalHoursLabel.Size = new System.Drawing.Size(56, 39);
            this.TotalHoursLabel.TabIndex = 21;
            this.TotalHoursLabel.Text = "0.0";
            // 
            // CuttingHoursLabel
            // 
            this.CuttingHoursLabel.AutoSize = true;
            this.CuttingHoursLabel.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CuttingHoursLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CuttingHoursLabel.Location = new System.Drawing.Point(267, 228);
            this.CuttingHoursLabel.Name = "CuttingHoursLabel";
            this.CuttingHoursLabel.Size = new System.Drawing.Size(43, 29);
            this.CuttingHoursLabel.TabIndex = 20;
            this.CuttingHoursLabel.Text = "0.0";
            // 
            // EdgeBandingHoursLabel
            // 
            this.EdgeBandingHoursLabel.AutoSize = true;
            this.EdgeBandingHoursLabel.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdgeBandingHoursLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EdgeBandingHoursLabel.Location = new System.Drawing.Point(267, 181);
            this.EdgeBandingHoursLabel.Name = "EdgeBandingHoursLabel";
            this.EdgeBandingHoursLabel.Size = new System.Drawing.Size(43, 29);
            this.EdgeBandingHoursLabel.TabIndex = 19;
            this.EdgeBandingHoursLabel.Text = "0.0";
            // 
            // DrawerHoursLabel
            // 
            this.DrawerHoursLabel.AutoSize = true;
            this.DrawerHoursLabel.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawerHoursLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DrawerHoursLabel.Location = new System.Drawing.Point(267, 134);
            this.DrawerHoursLabel.Name = "DrawerHoursLabel";
            this.DrawerHoursLabel.Size = new System.Drawing.Size(43, 29);
            this.DrawerHoursLabel.TabIndex = 18;
            this.DrawerHoursLabel.Text = "0.0";
            // 
            // BoxHoursLabel
            // 
            this.BoxHoursLabel.AutoSize = true;
            this.BoxHoursLabel.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxHoursLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BoxHoursLabel.Location = new System.Drawing.Point(267, 87);
            this.BoxHoursLabel.Name = "BoxHoursLabel";
            this.BoxHoursLabel.Size = new System.Drawing.Size(43, 29);
            this.BoxHoursLabel.TabIndex = 17;
            this.BoxHoursLabel.Text = "0.0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(15, 582);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 29);
            this.label12.TabIndex = 16;
            this.label12.Text = "Total Finished Parts:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(15, 537);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 29);
            this.label13.TabIndex = 15;
            this.label13.Text = "Total Drawers:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(15, 492);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 29);
            this.label14.TabIndex = 14;
            this.label14.Text = "Total Boxes:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Controls.Add(this.ReturnLabel);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 646);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(321, 75);
            this.panel4.TabIndex = 13;
            // 
            // ReturnLabel
            // 
            this.ReturnLabel.AutoSize = true;
            this.ReturnLabel.Font = new System.Drawing.Font("Calibri Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReturnLabel.Location = new System.Drawing.Point(239, 20);
            this.ReturnLabel.Name = "ReturnLabel";
            this.ReturnLabel.Size = new System.Drawing.Size(29, 35);
            this.ReturnLabel.TabIndex = 8;
            this.ReturnLabel.Text = "$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(15, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(218, 35);
            this.label11.TabIndex = 7;
            this.label11.Text = "Estimated Return:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(15, 447);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 29);
            this.label10.TabIndex = 12;
            this.label10.Text = "Total Doors:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(15, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 29);
            this.label9.TabIndex = 11;
            this.label9.Text = "Total Edge Barded:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(15, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total Sheets:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(17, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cutting Hours:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(15, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Edge Banding Hours:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(15, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Drawer Hours:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(15, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Box Hours:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(15, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Hours:";
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 10;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // business_ShopTableAdapter1
            // 
            this.business_ShopTableAdapter1.ClearBeforeFill = true;
            // 
            // jobsDataGridView
            // 
            this.jobsDataGridView.AllowUserToDeleteRows = false;
            this.jobsDataGridView.AllowUserToOrderColumns = true;
            this.jobsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.jobsDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.jobsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jobsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.jobsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobsDataGridView.Location = new System.Drawing.Point(31, 165);
            this.jobsDataGridView.MultiSelect = false;
            this.jobsDataGridView.Name = "jobsDataGridView";
            this.jobsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobsDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.jobsDataGridView.RowTemplate.Height = 24;
            this.jobsDataGridView.Size = new System.Drawing.Size(773, 463);
            this.jobsDataGridView.TabIndex = 10;
            // 
            // ApplyButton
            // 
            this.ApplyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ApplyButton.FlatAppearance.BorderSize = 0;
            this.ApplyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.ApplyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.ApplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyButton.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyButton.ForeColor = System.Drawing.Color.White;
            this.ApplyButton.Location = new System.Drawing.Point(496, 113);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(73, 34);
            this.ApplyButton.TabIndex = 11;
            this.ApplyButton.Text = "Apply!";
            this.ApplyButton.UseVisualStyleBackColor = false;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // ShopHistoryControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.TotalsPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShopDatePicker);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.jobsDataGridView);
            this.Name = "ShopHistoryControl";
            this.Size = new System.Drawing.Size(1073, 820);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TotalsPanel.ResumeLayout(false);
            this.TotalsPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker ShopDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel TotalsPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TotalBoxesLabel;
        private System.Windows.Forms.Label DoorsLabel;
        private System.Windows.Forms.Label EdgBardedLabel;
        private System.Windows.Forms.Label TotalSheetsLabel;
        private System.Windows.Forms.Label TotalHoursLabel;
        private System.Windows.Forms.Label CuttingHoursLabel;
        private System.Windows.Forms.Label EdgeBandingHoursLabel;
        private System.Windows.Forms.Label DrawerHoursLabel;
        private System.Windows.Forms.Label BoxHoursLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label ReturnLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label TotalFinishedPartsLabel;
        private System.Windows.Forms.Label TotalDrawersLabel;
        private System.Windows.Forms.Timer animationTimer;
        private _dovetail_dbDataSetTableAdapters.Business_ShopTableAdapter business_ShopTableAdapter1;
        private System.Windows.Forms.DataGridView jobsDataGridView;
        private System.Windows.Forms.Button ApplyButton;
    }
}
