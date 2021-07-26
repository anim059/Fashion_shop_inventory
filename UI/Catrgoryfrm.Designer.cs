namespace Fashion_shop_billing.UI
{
    partial class Catrgoryfrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CategoryClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryDataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserSearchBtn = new System.Windows.Forms.Button();
            this.searchCategory = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Category_title = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Category_id = new System.Windows.Forms.TextBox();
            this.Category_id_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CategoryDescription = new System.Windows.Forms.TextBox();
            this.categoryDelete = new System.Windows.Forms.Button();
            this.categoryUpdate = new System.Windows.Forms.Button();
            this.categoryAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.CategoryClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 36);
            this.panel1.TabIndex = 0;
            // 
            // CategoryClose
            // 
            this.CategoryClose.Image = global::Fashion_shop_billing.Properties.Resources.icons8_close_window_48;
            this.CategoryClose.Location = new System.Drawing.Point(987, 1);
            this.CategoryClose.Name = "CategoryClose";
            this.CategoryClose.Size = new System.Drawing.Size(40, 32);
            this.CategoryClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CategoryClose.TabIndex = 2;
            this.CategoryClose.TabStop = false;
            this.CategoryClose.Click += new System.EventHandler(this.CategoryClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(455, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category";
            // 
            // categoryDataGridView1
            // 
            this.categoryDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataGridView1.Location = new System.Drawing.Point(431, 120);
            this.categoryDataGridView1.Name = "categoryDataGridView1";
            this.categoryDataGridView1.RowHeadersWidth = 51;
            this.categoryDataGridView1.RowTemplate.Height = 24;
            this.categoryDataGridView1.Size = new System.Drawing.Size(554, 296);
            this.categoryDataGridView1.TabIndex = 41;
            this.categoryDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryDataGridView1_CellContentClick);
            this.categoryDataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.categoryDataGridView1_RowHeaderMouseClick);
            // 
            // UserSearchBtn
            // 
            this.UserSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UserSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSearchBtn.ForeColor = System.Drawing.Color.White;
            this.UserSearchBtn.Location = new System.Drawing.Point(906, 55);
            this.UserSearchBtn.Name = "UserSearchBtn";
            this.UserSearchBtn.Size = new System.Drawing.Size(79, 31);
            this.UserSearchBtn.TabIndex = 40;
            this.UserSearchBtn.Text = "Search";
            this.UserSearchBtn.UseVisualStyleBackColor = false;
            // 
            // searchCategory
            // 
            this.searchCategory.Location = new System.Drawing.Point(553, 60);
            this.searchCategory.Name = "searchCategory";
            this.searchCategory.Size = new System.Drawing.Size(316, 22);
            this.searchCategory.TabIndex = 39;
            this.searchCategory.TextChanged += new System.EventHandler(this.searchCategory_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(478, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 17);
            this.label13.TabIndex = 38;
            this.label13.Text = "Search";
            // 
            // Category_title
            // 
            this.Category_title.Location = new System.Drawing.Point(159, 196);
            this.Category_title.Name = "Category_title";
            this.Category_title.Size = new System.Drawing.Size(229, 22);
            this.Category_title.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(54, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "Title";
            // 
            // Category_id
            // 
            this.Category_id.Location = new System.Drawing.Point(159, 123);
            this.Category_id.Name = "Category_id";
            this.Category_id.ReadOnly = true;
            this.Category_id.Size = new System.Drawing.Size(229, 22);
            this.Category_id.TabIndex = 31;
            // 
            // Category_id_label
            // 
            this.Category_id_label.AutoSize = true;
            this.Category_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_id_label.Location = new System.Drawing.Point(54, 126);
            this.Category_id_label.Name = "Category_id_label";
            this.Category_id_label.Size = new System.Drawing.Size(91, 17);
            this.Category_id_label.TabIndex = 30;
            this.Category_id_label.Text = "Category Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Description";
            // 
            // CategoryDescription
            // 
            this.CategoryDescription.Location = new System.Drawing.Point(159, 270);
            this.CategoryDescription.Multiline = true;
            this.CategoryDescription.Name = "CategoryDescription";
            this.CategoryDescription.Size = new System.Drawing.Size(229, 146);
            this.CategoryDescription.TabIndex = 33;
            // 
            // categoryDelete
            // 
            this.categoryDelete.BackColor = System.Drawing.Color.Red;
            this.categoryDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoryDelete.Location = new System.Drawing.Point(751, 463);
            this.categoryDelete.Name = "categoryDelete";
            this.categoryDelete.Size = new System.Drawing.Size(172, 58);
            this.categoryDelete.TabIndex = 44;
            this.categoryDelete.Text = "DELETE";
            this.categoryDelete.UseVisualStyleBackColor = false;
            this.categoryDelete.Click += new System.EventHandler(this.categoryDelete_Click);
            // 
            // categoryUpdate
            // 
            this.categoryUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.categoryUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoryUpdate.Location = new System.Drawing.Point(466, 463);
            this.categoryUpdate.Name = "categoryUpdate";
            this.categoryUpdate.Size = new System.Drawing.Size(172, 58);
            this.categoryUpdate.TabIndex = 43;
            this.categoryUpdate.Text = "UPDATE";
            this.categoryUpdate.UseVisualStyleBackColor = false;
            this.categoryUpdate.Click += new System.EventHandler(this.categoryUpdate_Click);
            // 
            // categoryAdd
            // 
            this.categoryAdd.BackColor = System.Drawing.Color.Lime;
            this.categoryAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoryAdd.Location = new System.Drawing.Point(204, 463);
            this.categoryAdd.Name = "categoryAdd";
            this.categoryAdd.Size = new System.Drawing.Size(172, 58);
            this.categoryAdd.TabIndex = 42;
            this.categoryAdd.Text = "ADD";
            this.categoryAdd.UseVisualStyleBackColor = false;
            this.categoryAdd.Click += new System.EventHandler(this.categoryAdd_Click);
            // 
            // Catrgoryfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 561);
            this.Controls.Add(this.categoryDelete);
            this.Controls.Add(this.categoryUpdate);
            this.Controls.Add(this.categoryAdd);
            this.Controls.Add(this.categoryDataGridView1);
            this.Controls.Add(this.UserSearchBtn);
            this.Controls.Add(this.searchCategory);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Category_title);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CategoryDescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Category_id);
            this.Controls.Add(this.Category_id_label);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Catrgoryfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catrgoryfrm";
            this.Load += new System.EventHandler(this.Catrgoryfrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CategoryClose;
        private System.Windows.Forms.DataGridView categoryDataGridView1;
        private System.Windows.Forms.Button UserSearchBtn;
        private System.Windows.Forms.TextBox searchCategory;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Category_title;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Category_id;
        private System.Windows.Forms.Label Category_id_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CategoryDescription;
        private System.Windows.Forms.Button categoryDelete;
        private System.Windows.Forms.Button categoryUpdate;
        private System.Windows.Forms.Button categoryAdd;
    }
}