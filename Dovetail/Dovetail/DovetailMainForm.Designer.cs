using System;
using System.Windows.Forms;

namespace Dovetail
{
    partial class DovetailMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DovetailMainForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.navLabel = new System.Windows.Forms.Label();
            this.resizeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.navPanel = new System.Windows.Forms.Panel();
            this.installButton = new System.Windows.Forms.Button();
            this.sprayBoothButton = new System.Windows.Forms.Button();
            this.shopButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.usersTableAdapter1 = new Dovetail._dovetail_dbDataSetTableAdapters.UsersTableAdapter();
            this.doveButton = new System.Windows.Forms.Button();
            this.shopMainControl1 = new Dovetail.Displays.Shop.ShopMainControl();
            this.headerPanel.SuspendLayout();
            this.navPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(180)))));
            this.headerPanel.Controls.Add(this.maximizeButton);
            this.headerPanel.Controls.Add(this.navLabel);
            this.headerPanel.Controls.Add(this.resizeButton);
            this.headerPanel.Controls.Add(this.exitButton);
            this.headerPanel.Controls.Add(this.doveButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1390, 77);
            this.headerPanel.TabIndex = 0;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DoveMainForm_MouseDown);
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.maximizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximizeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maximizeButton.Location = new System.Drawing.Point(1290, 0);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(49, 40);
            this.maximizeButton.TabIndex = 4;
            this.maximizeButton.Text = "❒";
            this.maximizeButton.UseVisualStyleBackColor = true;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // navLabel
            // 
            this.navLabel.AutoSize = true;
            this.navLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.navLabel.Location = new System.Drawing.Point(168, 41);
            this.navLabel.Name = "navLabel";
            this.navLabel.Size = new System.Drawing.Size(0, 33);
            this.navLabel.TabIndex = 3;
            // 
            // resizeButton
            // 
            this.resizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resizeButton.FlatAppearance.BorderSize = 0;
            this.resizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.resizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.resizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resizeButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resizeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resizeButton.Location = new System.Drawing.Point(1235, 0);
            this.resizeButton.Name = "resizeButton";
            this.resizeButton.Size = new System.Drawing.Size(49, 40);
            this.resizeButton.TabIndex = 2;
            this.resizeButton.Text = "─";
            this.resizeButton.UseVisualStyleBackColor = true;
            this.resizeButton.Click += new System.EventHandler(this.resizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton.Location = new System.Drawing.Point(1341, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(49, 40);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "╳";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(47)))), ((int)(((byte)(79)))));
            this.navPanel.Controls.Add(this.installButton);
            this.navPanel.Controls.Add(this.sprayBoothButton);
            this.navPanel.Controls.Add(this.shopButton);
            this.navPanel.Controls.Add(this.homeButton);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPanel.Location = new System.Drawing.Point(0, 77);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(162, 663);
            this.navPanel.TabIndex = 1;
            // 
            // installButton
            // 
            this.installButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.installButton.FlatAppearance.BorderSize = 0;
            this.installButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.installButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.installButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.installButton.Location = new System.Drawing.Point(0, 156);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(162, 52);
            this.installButton.TabIndex = 5;
            this.installButton.Text = "Installs";
            this.installButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // sprayBoothButton
            // 
            this.sprayBoothButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.sprayBoothButton.FlatAppearance.BorderSize = 0;
            this.sprayBoothButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.sprayBoothButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sprayBoothButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sprayBoothButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sprayBoothButton.Location = new System.Drawing.Point(0, 104);
            this.sprayBoothButton.Name = "sprayBoothButton";
            this.sprayBoothButton.Size = new System.Drawing.Size(162, 52);
            this.sprayBoothButton.TabIndex = 4;
            this.sprayBoothButton.Text = "Spray Booth";
            this.sprayBoothButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sprayBoothButton.UseVisualStyleBackColor = true;
            this.sprayBoothButton.Click += new System.EventHandler(this.sprayBoothButton_Click);
            // 
            // shopButton
            // 
            this.shopButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.shopButton.FlatAppearance.BorderSize = 0;
            this.shopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.shopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shopButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shopButton.Location = new System.Drawing.Point(0, 52);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(162, 52);
            this.shopButton.TabIndex = 3;
            this.shopButton.Text = "Shop";
            this.shopButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shopButton.UseVisualStyleBackColor = true;
            this.shopButton.Click += new System.EventHandler(this.shopButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homeButton.Location = new System.Drawing.Point(0, 0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(162, 52);
            this.homeButton.TabIndex = 2;
            this.homeButton.Text = "Home";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // doveButton
            // 
            this.doveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(47)))), ((int)(((byte)(79)))));
            this.doveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("doveButton.BackgroundImage")));
            this.doveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.doveButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.doveButton.FlatAppearance.BorderSize = 0;
            this.doveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.doveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.doveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doveButton.Location = new System.Drawing.Point(0, 0);
            this.doveButton.Name = "doveButton";
            this.doveButton.Size = new System.Drawing.Size(162, 77);
            this.doveButton.TabIndex = 0;
            this.doveButton.UseVisualStyleBackColor = false;
            this.doveButton.Click += new System.EventHandler(this.doveButton_Click);
            // 
            // shopMainControl1
            // 
            this.shopMainControl1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.shopMainControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shopMainControl1.Location = new System.Drawing.Point(162, 77);
            this.shopMainControl1.Name = "shopMainControl1";
            this.shopMainControl1.Size = new System.Drawing.Size(1228, 663);
            this.shopMainControl1.TabIndex = 2;
            this.shopMainControl1.Visible = false;
            // 
            // DovetailMainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1390, 740);
            this.Controls.Add(this.shopMainControl1);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DovetailMainForm";
            this.Text = "DovetailMainForm";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.navPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// This method is responsible for reseting the back colors of the navigation buttons
        /// to match the navPanel's background. 
        /// </summary>
        private void resetSelectedButtonColor()
        {
            foreach(var button in navPanel.Controls)
            {
                if(button is Button)
                {
                    ((Button)button).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(47)))), ((int)(((byte)(79)))));
                }
            }
        }
        /// <summary>
        /// This method is responsible for setting the backcolor color of the selected button.
        /// </summary>
        /// <param name="selectedButton">Winform Button highlight.</param>
        private void highlightSelectedButton(Button selectedButton)
        {
            selectedButton.BackColor = System.Drawing.Color.DeepSkyBlue;
        }
        /// <summary>
        /// This method is responsible for setting the navigation label at the top of the screen. 
        /// </summary>
        /// <param name="button"></param>
        private void setNavLabel(Button button)
        {
            this.navLabel.Text = button.Text;
        }

        /// <summary>
        /// This method is responsible handling the button that is clicked. 
        /// </summary>
        /// <param name="button"></param>
        private void navbuttonClick(Button button)
        {
            resetSelectedButtonColor();
            highlightSelectedButton(button);
            setNavLabel(button);
        }


        /// <summary>
        /// The Following Section handles movement of the bordless form.
        /// </summary>
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DoveMainForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button doveButton;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button resizeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Button sprayBoothButton;
        private System.Windows.Forms.Button shopButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label navLabel;
        private _dovetail_dbDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private Button maximizeButton;
        private Displays.Shop.ShopMainControl shopMainControl1;
    }
}