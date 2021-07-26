namespace Fashion_shop_billing.UI
{
    partial class Userfrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.UserIdBox = new System.Windows.Forms.TextBox();
            this.UserAdressBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UserContactBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UserPassBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UserlastNameBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.userEmailBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.userFirstNameBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.UsergenderBox = new System.Windows.Forms.ComboBox();
            this.UsertypeBox = new System.Windows.Forms.ComboBox();
            this.userAdd = new System.Windows.Forms.Button();
            this.userUpdate = new System.Windows.Forms.Button();
            this.userDelete = new System.Windows.Forms.Button();
            this.searchUser = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.UserSearchBtn = new System.Windows.Forms.Button();
            this.userDataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 37);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(421, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Form";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(21, 74);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(60, 17);
            this.lbl_id.TabIndex = 3;
            this.lbl_id.Text = "User Id";
            // 
            // UserIdBox
            // 
            this.UserIdBox.Location = new System.Drawing.Point(126, 71);
            this.UserIdBox.Name = "UserIdBox";
            this.UserIdBox.ReadOnly = true;
            this.UserIdBox.Size = new System.Drawing.Size(229, 22);
            this.UserIdBox.TabIndex = 4;
            // 
            // UserAdressBox
            // 
            this.UserAdressBox.Location = new System.Drawing.Point(126, 361);
            this.UserAdressBox.Multiline = true;
            this.UserAdressBox.Name = "UserAdressBox";
            this.UserAdressBox.Size = new System.Drawing.Size(229, 88);
            this.UserAdressBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address";
            // 
            // UserContactBox
            // 
            this.UserContactBox.Location = new System.Drawing.Point(126, 317);
            this.UserContactBox.Name = "UserContactBox";
            this.UserContactBox.Size = new System.Drawing.Size(229, 22);
            this.UserContactBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contact";
            // 
            // UserPassBox
            // 
            this.UserPassBox.Location = new System.Drawing.Point(126, 275);
            this.UserPassBox.Name = "UserPassBox";
            this.UserPassBox.PasswordChar = '*';
            this.UserPassBox.Size = new System.Drawing.Size(229, 22);
            this.UserPassBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Password";
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(126, 234);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(229, 22);
            this.userNameBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Username";
            // 
            // UserlastNameBox
            // 
            this.UserlastNameBox.Location = new System.Drawing.Point(126, 149);
            this.UserlastNameBox.Name = "UserlastNameBox";
            this.UserlastNameBox.Size = new System.Drawing.Size(229, 22);
            this.UserlastNameBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Last Name";
            // 
            // userEmailBox
            // 
            this.userEmailBox.Location = new System.Drawing.Point(126, 193);
            this.userEmailBox.Name = "userEmailBox";
            this.userEmailBox.Size = new System.Drawing.Size(229, 22);
            this.userEmailBox.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Email";
            // 
            // userFirstNameBox
            // 
            this.userFirstNameBox.Location = new System.Drawing.Point(126, 109);
            this.userFirstNameBox.Name = "userFirstNameBox";
            this.userFirstNameBox.Size = new System.Drawing.Size(229, 22);
            this.userFirstNameBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "First Nane";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 519);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "User Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 473);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Gender";
            // 
            // UsergenderBox
            // 
            this.UsergenderBox.FormattingEnabled = true;
            this.UsergenderBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Third Gender"});
            this.UsergenderBox.Location = new System.Drawing.Point(126, 473);
            this.UsergenderBox.Name = "UsergenderBox";
            this.UsergenderBox.Size = new System.Drawing.Size(229, 24);
            this.UsergenderBox.TabIndex = 21;
            // 
            // UsertypeBox
            // 
            this.UsertypeBox.FormattingEnabled = true;
            this.UsertypeBox.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.UsertypeBox.Location = new System.Drawing.Point(126, 516);
            this.UsertypeBox.Name = "UsertypeBox";
            this.UsertypeBox.Size = new System.Drawing.Size(229, 24);
            this.UsertypeBox.TabIndex = 22;
            // 
            // userAdd
            // 
            this.userAdd.BackColor = System.Drawing.Color.Lime;
            this.userAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userAdd.Location = new System.Drawing.Point(163, 575);
            this.userAdd.Name = "userAdd";
            this.userAdd.Size = new System.Drawing.Size(172, 58);
            this.userAdd.TabIndex = 23;
            this.userAdd.Text = "ADD";
            this.userAdd.UseVisualStyleBackColor = false;
            this.userAdd.Click += new System.EventHandler(this.userAdd_Click);
            // 
            // userUpdate
            // 
            this.userUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.userUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userUpdate.Location = new System.Drawing.Point(425, 575);
            this.userUpdate.Name = "userUpdate";
            this.userUpdate.Size = new System.Drawing.Size(172, 58);
            this.userUpdate.TabIndex = 24;
            this.userUpdate.Text = "UPDATE";
            this.userUpdate.UseVisualStyleBackColor = false;
            this.userUpdate.Click += new System.EventHandler(this.userUpdate_Click);
            // 
            // userDelete
            // 
            this.userDelete.BackColor = System.Drawing.Color.Red;
            this.userDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userDelete.Location = new System.Drawing.Point(710, 575);
            this.userDelete.Name = "userDelete";
            this.userDelete.Size = new System.Drawing.Size(172, 58);
            this.userDelete.TabIndex = 25;
            this.userDelete.Text = "DELETE";
            this.userDelete.UseVisualStyleBackColor = false;
            this.userDelete.Click += new System.EventHandler(this.userDelete_Click);
            // 
            // searchUser
            // 
            this.searchUser.Location = new System.Drawing.Point(521, 74);
            this.searchUser.Name = "searchUser";
            this.searchUser.Size = new System.Drawing.Size(316, 22);
            this.searchUser.TabIndex = 27;
            this.searchUser.TextChanged += new System.EventHandler(this.searchUser_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(446, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "Search";
            // 
            // UserSearchBtn
            // 
            this.UserSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UserSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSearchBtn.ForeColor = System.Drawing.Color.White;
            this.UserSearchBtn.Location = new System.Drawing.Point(874, 69);
            this.UserSearchBtn.Name = "UserSearchBtn";
            this.UserSearchBtn.Size = new System.Drawing.Size(79, 31);
            this.UserSearchBtn.TabIndex = 28;
            this.UserSearchBtn.Text = "Search";
            this.UserSearchBtn.UseVisualStyleBackColor = false;
            // 
            // userDataGridView1
            // 
            this.userDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView1.Location = new System.Drawing.Point(399, 134);
            this.userDataGridView1.Name = "userDataGridView1";
            this.userDataGridView1.RowHeadersWidth = 51;
            this.userDataGridView1.RowTemplate.Height = 24;
            this.userDataGridView1.Size = new System.Drawing.Size(554, 386);
            this.userDataGridView1.TabIndex = 29;
            this.userDataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.userDataGridView1_RowHeaderMouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fashion_shop_billing.Properties.Resources.icons8_close_window_48;
            this.pictureBox1.Location = new System.Drawing.Point(939, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Userfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(991, 660);
            this.Controls.Add(this.userDataGridView1);
            this.Controls.Add(this.UserSearchBtn);
            this.Controls.Add(this.searchUser);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.userDelete);
            this.Controls.Add(this.userUpdate);
            this.Controls.Add(this.userAdd);
            this.Controls.Add(this.UsertypeBox);
            this.Controls.Add(this.UsergenderBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.userFirstNameBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.userEmailBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.UserlastNameBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UserPassBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UserContactBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UserAdressBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserIdBox);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Userfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Userfrm";
            this.Load += new System.EventHandler(this.Userfrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox UserIdBox;
        private System.Windows.Forms.TextBox UserAdressBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserContactBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UserPassBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UserlastNameBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox userEmailBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox userFirstNameBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox UsergenderBox;
        private System.Windows.Forms.ComboBox UsertypeBox;
        private System.Windows.Forms.Button userAdd;
        private System.Windows.Forms.Button userUpdate;
        private System.Windows.Forms.Button userDelete;
        private System.Windows.Forms.TextBox searchUser;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button UserSearchBtn;
        private System.Windows.Forms.DataGridView userDataGridView1;
    }
}