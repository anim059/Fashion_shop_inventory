namespace Fashion_shop_billing
{
    partial class AdminDashbroad
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
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.AdDashPanel1 = new System.Windows.Forms.Panel();
            this.AdminFotter = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dealerCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminUserlabel = new System.Windows.Forms.Label();
            this.AdminUserName = new System.Windows.Forms.Label();
            this.SftName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AdDashPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // AdDashPanel1
            // 
            this.AdDashPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AdDashPanel1.Controls.Add(this.AdminFotter);
            this.AdDashPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AdDashPanel1.Location = new System.Drawing.Point(0, 661);
            this.AdDashPanel1.Name = "AdDashPanel1";
            this.AdDashPanel1.Size = new System.Drawing.Size(1482, 44);
            this.AdDashPanel1.TabIndex = 0;
            this.AdDashPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.AdDashPanel1_Paint);
            // 
            // AdminFotter
            // 
            this.AdminFotter.AutoSize = true;
            this.AdminFotter.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminFotter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AdminFotter.Location = new System.Drawing.Point(910, 15);
            this.AdminFotter.Name = "AdminFotter";
            this.AdminFotter.Size = new System.Drawing.Size(232, 20);
            this.AdminFotter.TabIndex = 0;
            this.AdminFotter.Text = "Made By Istiaque Hahsem";
            this.AdminFotter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdminFotter.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.productToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.tranToolStripMenuItem,
            this.dealerCustomerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1482, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // tranToolStripMenuItem
            // 
            this.tranToolStripMenuItem.Name = "tranToolStripMenuItem";
            this.tranToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.tranToolStripMenuItem.Text = "Transaction";
            // 
            // dealerCustomerToolStripMenuItem
            // 
            this.dealerCustomerToolStripMenuItem.Name = "dealerCustomerToolStripMenuItem";
            this.dealerCustomerToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.dealerCustomerToolStripMenuItem.Text = "Dealer Customer";
            this.dealerCustomerToolStripMenuItem.Click += new System.EventHandler(this.dealerCustomerToolStripMenuItem_Click);
            // 
            // AdminUserlabel
            // 
            this.AdminUserlabel.AutoSize = true;
            this.AdminUserlabel.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminUserlabel.Location = new System.Drawing.Point(16, 60);
            this.AdminUserlabel.Name = "AdminUserlabel";
            this.AdminUserlabel.Size = new System.Drawing.Size(62, 20);
            this.AdminUserlabel.TabIndex = 4;
            this.AdminUserlabel.Text = "User : ";
            this.AdminUserlabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // AdminUserName
            // 
            this.AdminUserName.AutoSize = true;
            this.AdminUserName.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AdminUserName.Location = new System.Drawing.Point(74, 60);
            this.AdminUserName.Name = "AdminUserName";
            this.AdminUserName.Size = new System.Drawing.Size(0, 20);
            this.AdminUserName.TabIndex = 5;
            this.AdminUserName.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // SftName
            // 
            this.SftName.AccessibleDescription = "";
            this.SftName.AutoSize = true;
            this.SftName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SftName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SftName.Font = new System.Drawing.Font("SimSun", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SftName.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.SftName.Location = new System.Drawing.Point(779, 385);
            this.SftName.Name = "SftName";
            this.SftName.Size = new System.Drawing.Size(528, 82);
            this.SftName.TabIndex = 6;
            this.SftName.Text = "Fashion Shop";
            this.SftName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(859, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Billing and Inventory Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminDashbroad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1482, 705);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SftName);
            this.Controls.Add(this.AdminUserName);
            this.Controls.Add(this.AdminUserlabel);
            this.Controls.Add(this.AdDashPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminDashbroad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashbroad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashbroad_FormClosed);
            this.Load += new System.EventHandler(this.AdminDashbroad_Load);
            this.AdDashPanel1.ResumeLayout(false);
            this.AdDashPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel AdDashPanel1;
        private System.Windows.Forms.Label AdminFotter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tranToolStripMenuItem;
        private System.Windows.Forms.Label AdminUserlabel;
        private System.Windows.Forms.Label AdminUserName;
        private System.Windows.Forms.Label SftName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem dealerCustomerToolStripMenuItem;
    }
}

