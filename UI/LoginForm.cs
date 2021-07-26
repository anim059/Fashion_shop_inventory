using Fashion_shop_billing.BLL;
using Fashion_shop_billing.DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fashion_shop_billing.UI
{
    public partial class LoginForm : Form
    {
        loginFromBll b = new loginFromBll();
        loginFormDll d = new loginFormDll();
        public static string loginName;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lgnformCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lgn_btn_Click(object sender, EventArgs e)
        {
            b.username = lgnUserName.Text.Trim();
            b.password = lgnPassWord.Text.Trim();
            b.user_type = lgnUserType.Text.Trim();

           
            bool isSuccess = d.CheckUser(b);

            if (isSuccess == true)
            {
                MessageBox.Show("You Login SuccessFully");
                loginName = b.username;
                switch (b.user_type)
                {
                    case "Admin":
                        {
                            AdminDashbroad admin = new AdminDashbroad();
                            admin.Show();
                            this.Hide();
                        }
                        break;
                    case "User":
                        {
                            UserDashbroad user = new UserDashbroad();
                                user.Show();
                                this.Hide();
                        }
                        break;
                    default:
                        {
                            MessageBox.Show("Invalid User Type");
                        }
                        break;

                }
            }
            else
            {
                MessageBox.Show("Login Fail");
            }
        }
    }
}
