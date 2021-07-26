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
    public partial class UserDashbroad : Form
    {
        public UserDashbroad()
        {
            InitializeComponent();
        }
        public static string transactionType;
        private void UserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            PurchaseAndSales sale = new PurchaseAndSales();
            transactionType = "Sale";
            sale.Show();
        }

        private void UserDashbroad_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void UserDashbroad_Load(object sender, EventArgs e)
        {
            UserName.Text = LoginForm.loginName;
        }

        private void dealerCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dealer_Customer dc = new Dealer_Customer();
            dc.Show();
        }

        private void UpurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            PurchaseAndSales purchase = new PurchaseAndSales();
            transactionType = "Purchase";
            purchase.Show();
        }
    }
}
