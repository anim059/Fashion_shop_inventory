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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        ProductDll pd = new ProductDll();
        ProductBll pb = new ProductBll();
        userDll ud = new userDll();
        private void ProductCloseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string search = ProductSearch.Text;
            if(search != null)
            {
                DataTable dt = pd.Search(search);
                productdataGridView1.DataSource = dt;
            }
            else
            {
                DataTable dt = pd.Select();
                productdataGridView1.DataSource = dt;
            }
        }

        private void productAdd_Click(object sender, EventArgs e)
        {
            if (ProductName.Text != "" && ProductCategory.Text != "" && ProductDescrip.Text != "" && ProductRate.Text != "")
            {
                string loginname = LoginForm.loginName;
                UserBll adminid = ud.FindId(loginname);

                pb.name = ProductName.Text;
                pb.category = ProductCategory.Text;
                pb.description = ProductDescrip.Text;
                pb.rate = decimal.Parse(ProductRate.Text);
                pb.qty = 0;
                pb.added_date = DateTime.Now;
                pb.added_by = adminid.id;

                bool isSuccess = pd.Insert(pb);
                if(isSuccess == true)
                {
                    MessageBox.Show("Product successfully created");
                    DataTable dt = pd.Select();
                    productdataGridView1.DataSource = dt;
                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to add user");
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Please fill all the field");
            }
        }
        CategoryDll cd = new CategoryDll();
        private void ProductForm_Load(object sender, EventArgs e)
        {
            DataTable dtcat = cd.Select();
            ProductCategory.DataSource = dtcat;
            ProductCategory.DisplayMember = "title";
            ProductCategory.ValueMember = "title";

            DataTable dt = pd.Select();
            productdataGridView1.DataSource = dt;
        }

        private void ProductRate_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void productUpdate_Click(object sender, EventArgs e)
        {
            if (ProductName.Text != "" && ProductCategory.Text != "" && ProductDescrip.Text != "" && ProductRate.Text != "")
            {
                string loginname = LoginForm.loginName;
                UserBll adminid = ud.FindId(loginname);

                pb.id = Convert.ToInt32(Productid.Text);
                pb.name = ProductName.Text;
                pb.category = ProductCategory.Text;
                pb.description = ProductDescrip.Text;
                pb.rate = decimal.Parse(ProductRate.Text);
                pb.qty = 0;
                pb.added_date = DateTime.Now;
                pb.added_by = adminid.id;

                bool isSuccess = pd.Update(pb);
                if (isSuccess == true)
                {
                    MessageBox.Show("Product successfully Updated");
                    DataTable dt = pd.Select();
                    productdataGridView1.DataSource = dt;
                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to add product");
                }
            }
            else
            {
                MessageBox.Show("Fill all the field product");
                Clear();
            }
        }
        void Clear()
        {
            Productid.Text = "";
            ProductName.Text = "";
            ProductCategory.Text = "";
            ProductDescrip.Text = "";
            ProductRate.Text = "";
        }

        private void productdataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            int rowIndex = e.RowIndex;
            Productid.Text = productdataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            ProductName.Text = productdataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            ProductCategory.Text = productdataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            ProductDescrip.Text = productdataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            ProductRate.Text = productdataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            
        }

        private void productdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productDelete_Click(object sender, EventArgs e)
        {
            pb.id = Convert.ToInt32(Productid.Text);
            bool isSuccess = pd.Delete(pb);
            if(isSuccess == true)
            {
                MessageBox.Show("Product Successfully Deleted");
                DataTable dt = pd.Select();
                productdataGridView1.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Delete product");
            }
        }
    }
}
