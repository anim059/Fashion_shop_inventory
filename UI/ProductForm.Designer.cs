namespace Fashion_shop_billing.UI
{
    partial class ProductForm
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
            this.ProductCloseBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductIdlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Productid = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.ProductDescrip = new System.Windows.Forms.TextBox();
            this.ProductRate = new System.Windows.Forms.TextBox();
            this.productDelete = new System.Windows.Forms.Button();
            this.productUpdate = new System.Windows.Forms.Button();
            this.productAdd = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.ProductSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.ProductSearchBtn = new System.Windows.Forms.Button();
            this.productdataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductCategory = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.ProductCloseBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 39);
            this.panel1.TabIndex = 0;
            // 
            // ProductCloseBtn
            // 
            this.ProductCloseBtn.Image = global::Fashion_shop_billing.Properties.Resources.icons8_close_window_48;
            this.ProductCloseBtn.Location = new System.Drawing.Point(960, 3);
            this.ProductCloseBtn.Name = "ProductCloseBtn";
            this.ProductCloseBtn.Size = new System.Drawing.Size(40, 32);
            this.ProductCloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductCloseBtn.TabIndex = 2;
            this.ProductCloseBtn.TabStop = false;
            this.ProductCloseBtn.Click += new System.EventHandler(this.ProductCloseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(391, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Form";
            // 
            // ProductIdlbl
            // 
            this.ProductIdlbl.AutoSize = true;
            this.ProductIdlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIdlbl.Location = new System.Drawing.Point(32, 87);
            this.ProductIdlbl.Name = "ProductIdlbl";
            this.ProductIdlbl.Size = new System.Drawing.Size(82, 17);
            this.ProductIdlbl.TabIndex = 1;
            this.ProductIdlbl.Text = "Product Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Product Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rate";
            // 
            // Productid
            // 
            this.Productid.Location = new System.Drawing.Point(178, 87);
            this.Productid.Name = "Productid";
            this.Productid.ReadOnly = true;
            this.Productid.Size = new System.Drawing.Size(220, 22);
            this.Productid.TabIndex = 6;
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(178, 148);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(220, 22);
            this.ProductName.TabIndex = 7;
            // 
            // ProductDescrip
            // 
            this.ProductDescrip.Location = new System.Drawing.Point(178, 290);
            this.ProductDescrip.Multiline = true;
            this.ProductDescrip.Name = "ProductDescrip";
            this.ProductDescrip.Size = new System.Drawing.Size(220, 106);
            this.ProductDescrip.TabIndex = 9;
            // 
            // ProductRate
            // 
            this.ProductRate.Location = new System.Drawing.Point(178, 422);
            this.ProductRate.Name = "ProductRate";
            this.ProductRate.Size = new System.Drawing.Size(220, 22);
            this.ProductRate.TabIndex = 10;
            this.ProductRate.TextChanged += new System.EventHandler(this.ProductRate_TextChanged);
            // 
            // productDelete
            // 
            this.productDelete.BackColor = System.Drawing.Color.Red;
            this.productDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productDelete.Location = new System.Drawing.Point(661, 539);
            this.productDelete.Name = "productDelete";
            this.productDelete.Size = new System.Drawing.Size(172, 58);
            this.productDelete.TabIndex = 28;
            this.productDelete.Text = "DELETE";
            this.productDelete.UseVisualStyleBackColor = false;
            this.productDelete.Click += new System.EventHandler(this.productDelete_Click);
            // 
            // productUpdate
            // 
            this.productUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.productUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productUpdate.Location = new System.Drawing.Point(376, 539);
            this.productUpdate.Name = "productUpdate";
            this.productUpdate.Size = new System.Drawing.Size(172, 58);
            this.productUpdate.TabIndex = 27;
            this.productUpdate.Text = "UPDATE";
            this.productUpdate.UseVisualStyleBackColor = false;
            this.productUpdate.Click += new System.EventHandler(this.productUpdate_Click);
            // 
            // productAdd
            // 
            this.productAdd.BackColor = System.Drawing.Color.Lime;
            this.productAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productAdd.Location = new System.Drawing.Point(114, 539);
            this.productAdd.Name = "productAdd";
            this.productAdd.Size = new System.Drawing.Size(172, 58);
            this.productAdd.TabIndex = 26;
            this.productAdd.Text = "ADD";
            this.productAdd.UseVisualStyleBackColor = false;
            this.productAdd.Click += new System.EventHandler(this.productAdd_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // ProductSearch
            // 
            this.ProductSearch.Location = new System.Drawing.Point(583, 87);
            this.ProductSearch.Name = "ProductSearch";
            this.ProductSearch.Size = new System.Drawing.Size(220, 22);
            this.ProductSearch.TabIndex = 30;
            this.ProductSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(504, 87);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(59, 17);
            this.Search.TabIndex = 29;
            this.Search.Text = "Search";
            this.Search.Click += new System.EventHandler(this.label6_Click);
            // 
            // ProductSearchBtn
            // 
            this.ProductSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProductSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSearchBtn.ForeColor = System.Drawing.Color.White;
            this.ProductSearchBtn.Location = new System.Drawing.Point(834, 82);
            this.ProductSearchBtn.Name = "ProductSearchBtn";
            this.ProductSearchBtn.Size = new System.Drawing.Size(79, 31);
            this.ProductSearchBtn.TabIndex = 31;
            this.ProductSearchBtn.Text = "Search";
            this.ProductSearchBtn.UseVisualStyleBackColor = false;
            // 
            // productdataGridView1
            // 
            this.productdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productdataGridView1.Location = new System.Drawing.Point(439, 135);
            this.productdataGridView1.Name = "productdataGridView1";
            this.productdataGridView1.RowHeadersWidth = 51;
            this.productdataGridView1.RowTemplate.Height = 24;
            this.productdataGridView1.Size = new System.Drawing.Size(545, 358);
            this.productdataGridView1.TabIndex = 32;
            this.productdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productdataGridView1_CellContentClick);
            this.productdataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productdataGridView1_RowHeaderMouseClick);
            // 
            // ProductCategory
            // 
            this.ProductCategory.FormattingEnabled = true;
            this.ProductCategory.Location = new System.Drawing.Point(178, 212);
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.Size = new System.Drawing.Size(220, 24);
            this.ProductCategory.TabIndex = 33;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 625);
            this.Controls.Add(this.ProductCategory);
            this.Controls.Add(this.productdataGridView1);
            this.Controls.Add(this.ProductSearchBtn);
            this.Controls.Add(this.ProductSearch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.productDelete);
            this.Controls.Add(this.productUpdate);
            this.Controls.Add(this.productAdd);
            this.Controls.Add(this.ProductRate);
            this.Controls.Add(this.ProductDescrip);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.Productid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductIdlbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ProductCloseBtn;
        private System.Windows.Forms.Label ProductIdlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Productid;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox ProductDescrip;
        private System.Windows.Forms.TextBox ProductRate;
        private System.Windows.Forms.Button productDelete;
        private System.Windows.Forms.Button productUpdate;
        private System.Windows.Forms.Button productAdd;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox ProductSearch;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button ProductSearchBtn;
        private System.Windows.Forms.DataGridView productdataGridView1;
        private System.Windows.Forms.ComboBox ProductCategory;
    }
}