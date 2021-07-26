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
    public partial class Catrgoryfrm : Form
    {
        public Catrgoryfrm()
        {
            InitializeComponent();
        }
        CategoryBll cb = new CategoryBll();
        CategoryDll cd = new CategoryDll();
        userDll dal = new userDll();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CategoryClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void categoryAdd_Click(object sender, EventArgs e)
        {
            if (Category_title.Text != "" && CategoryDescription.Text != "")
            {
                string loginIdname = LoginForm.loginName;

                UserBll adminId = dal.FindId(loginIdname);

                cb.title = Category_title.Text;
                cb.description = CategoryDescription.Text;
                cb.added_date = DateTime.Now;
                cb.added_by = adminId.id;

                bool isSuccess = cd.Insert(cb);
                if (isSuccess = true)
                {
                    MessageBox.Show("Category successfully created");
                    DataTable dt = cd.Select();
                    categoryDataGridView1.DataSource = dt;
                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to add category");
                }

            }
            else
            {
                MessageBox.Show("Please Fillup All Field");
                return;
            }
        }

        

        private void categoryUpdate_Click(object sender, EventArgs e)
        {
            if (Category_title.Text != "" && CategoryDescription.Text !="" )
            {
                string loginIdname = LoginForm.loginName;

                UserBll adminId = dal.FindId(loginIdname);

                cb.id = Convert.ToInt32(Category_id.Text);
                cb.title = Category_title.Text;
                cb.description = CategoryDescription.Text;
                cb.added_date = DateTime.Now;
                cb.added_by = adminId.id;


                bool isSuccess = cd.Update(cb);
                if (isSuccess = true)
                {
                    MessageBox.Show("Category Successfully Updated");
                    DataTable dt = cd.Select();
                    categoryDataGridView1.DataSource = dt;
                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to Update Category");
                }

            }
            else
            {
                MessageBox.Show("Please Fillup All Field");
            }
        }

        private void categoryDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void Catrgoryfrm_Load(object sender, EventArgs e)
        {
            DataTable dt = cd.Select();
            categoryDataGridView1.DataSource = dt;
        }

        private void categoryDataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            Category_id.Text = categoryDataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            Category_title.Text = categoryDataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            CategoryDescription.Text = categoryDataGridView1.Rows[rowindex].Cells[2].Value.ToString();
        }

        private void categoryDelete_Click(object sender, EventArgs e)
        {
            cb.id = Convert.ToInt32(Category_id.Text);
            bool isDelete = cd.Delect(cb);
            if (isDelete)
            {
                MessageBox.Show("User Successfully Deleted");
                DataTable dt = cd.Select();
                categoryDataGridView1.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Delete User");
            }
        }

        public void Clear()
        {
            Category_id.Text = "";
            Category_title.Text = " ";
            CategoryDescription.Text = " ";
        }

        private void searchCategory_TextChanged(object sender, EventArgs e)
        {
            string search = searchCategory.Text;
            if (search != null)
            {
                DataTable dt = cd.Search(search);
                categoryDataGridView1.DataSource = dt;
            }
            else
            {
                DataTable dt = cd.Select();
                categoryDataGridView1.DataSource = dt;
            }
        }
    }
}
