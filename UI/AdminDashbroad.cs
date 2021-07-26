using Fashion_shop_billing.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fashion_shop_billing
{
    public partial class AdminDashbroad : Form
    {
        public AdminDashbroad()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdDashPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Userfrm user = new Userfrm();
            user.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catrgoryfrm catfm = new Catrgoryfrm();
            catfm.Show();
        }

        private void AdminDashbroad_Load(object sender, EventArgs e)
        {
            AdminUserName.Text = LoginForm.loginName;
        }

        private void AdminDashbroad_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm();
            pf.Show();
        }

        private void dealerCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dealer_Customer DC = new Dealer_Customer();
            DC.Show();
        }
    }
}
