namespace Fashion_shop_billing.UI
{
    partial class LoginForm
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
            this.lgn_btn = new System.Windows.Forms.Button();
            this.labelbox = new System.Windows.Forms.Label();
            this.lgnPassWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lgnUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lgnformCloseBtn = new System.Windows.Forms.PictureBox();
            this.lgnUserType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lgnformCloseBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lgnUserType);
            this.panel1.Controls.Add(this.lgn_btn);
            this.panel1.Controls.Add(this.labelbox);
            this.panel1.Controls.Add(this.lgnPassWord);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lgnUserName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(53, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 494);
            this.panel1.TabIndex = 0;
            // 
            // lgn_btn
            // 
            this.lgn_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lgn_btn.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgn_btn.Location = new System.Drawing.Point(127, 391);
            this.lgn_btn.Name = "lgn_btn";
            this.lgn_btn.Size = new System.Drawing.Size(234, 68);
            this.lgn_btn.TabIndex = 7;
            this.lgn_btn.Text = "Login";
            this.lgn_btn.UseVisualStyleBackColor = false;
            this.lgn_btn.Click += new System.EventHandler(this.lgn_btn_Click);
            // 
            // labelbox
            // 
            this.labelbox.AutoSize = true;
            this.labelbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbox.Location = new System.Drawing.Point(35, 330);
            this.labelbox.Name = "labelbox";
            this.labelbox.Size = new System.Drawing.Size(84, 20);
            this.labelbox.TabIndex = 5;
            this.labelbox.Text = "Usertype";
            // 
            // lgnPassWord
            // 
            this.lgnPassWord.Location = new System.Drawing.Point(147, 235);
            this.lgnPassWord.Multiline = true;
            this.lgnPassWord.Name = "lgnPassWord";
            this.lgnPassWord.PasswordChar = '*';
            this.lgnPassWord.Size = new System.Drawing.Size(202, 34);
            this.lgnPassWord.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lgnUserName
            // 
            this.lgnUserName.Location = new System.Drawing.Point(147, 148);
            this.lgnUserName.Multiline = true;
            this.lgnUserName.Name = "lgnUserName";
            this.lgnUserName.Size = new System.Drawing.Size(202, 35);
            this.lgnUserName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lgnformCloseBtn
            // 
            this.lgnformCloseBtn.Image = global::Fashion_shop_billing.Properties.Resources.icons8_close_window_48;
            this.lgnformCloseBtn.Location = new System.Drawing.Point(514, 12);
            this.lgnformCloseBtn.Name = "lgnformCloseBtn";
            this.lgnformCloseBtn.Size = new System.Drawing.Size(40, 32);
            this.lgnformCloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lgnformCloseBtn.TabIndex = 2;
            this.lgnformCloseBtn.TabStop = false;
            this.lgnformCloseBtn.Click += new System.EventHandler(this.lgnformCloseBtn_Click);
            // 
            // lgnUserType
            // 
            this.lgnUserType.FormattingEnabled = true;
            this.lgnUserType.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.lgnUserType.Location = new System.Drawing.Point(147, 330);
            this.lgnUserType.Name = "lgnUserType";
            this.lgnUserType.Size = new System.Drawing.Size(202, 24);
            this.lgnUserType.TabIndex = 9;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(566, 595);
            this.Controls.Add(this.lgnformCloseBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lgnformCloseBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lgnPassWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lgnUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelbox;
        private System.Windows.Forms.Button lgn_btn;
        private System.Windows.Forms.PictureBox lgnformCloseBtn;
        private System.Windows.Forms.ComboBox lgnUserType;
    }
}