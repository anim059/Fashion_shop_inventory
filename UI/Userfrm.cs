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
    public partial class Userfrm : Form
    {
        public Userfrm()
        {
            InitializeComponent();
        }
        UserBll u = new UserBll();
        userDll dal = new userDll();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userAdd_Click(object sender, EventArgs e)
        {
            if( userFirstNameBox.Text != "" && UserlastNameBox.Text != "" && userEmailBox.Text != "" && userNameBox.Text != ""
                && UserPassBox.Text != "" && UserContactBox.Text != "" && UserAdressBox.Text != "" && UsergenderBox.Text != ""
                && UsertypeBox.Text != "")
            {
                string loginIdname = LoginForm.loginName;

                UserBll adminId = dal.FindId(loginIdname);

                u.first_name = userFirstNameBox.Text;
                u.last_name = UserlastNameBox.Text;
                u.email = userEmailBox.Text;
                u.username = userNameBox.Text;
                u.password = UserPassBox.Text;
                u.contact = UserContactBox.Text;
                u.address = UserAdressBox.Text;
                u.gender = UsergenderBox.Text;
                u.user_type = UsertypeBox.Text;
                u.added_date = DateTime.Now;
                u.added_by = adminId.id;

                bool isSuccess = dal.Insert(u);
                if (isSuccess = true)
                {
                    MessageBox.Show("User successfully created");
                    DataTable dt = dal.Select();
                    userDataGridView1.DataSource = dt;
                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to add user");
                }

            }
            else
            {
                MessageBox.Show("Please Fillup All Field");
                return;
            }
          
        }

        private void Userfrm_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            userDataGridView1.DataSource = dt;
        }
       

        private void userDataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            UserIdBox.Text = userDataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            userFirstNameBox.Text = userDataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            UserlastNameBox.Text = userDataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            userEmailBox.Text = userDataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            userNameBox.Text = userDataGridView1.Rows[rowindex].Cells[4].Value.ToString();
            UserPassBox.Text = userDataGridView1.Rows[rowindex].Cells[5].Value.ToString();
            UserContactBox.Text = userDataGridView1.Rows[rowindex].Cells[6].Value.ToString();
            UserAdressBox.Text = userDataGridView1.Rows[rowindex].Cells[7].Value.ToString();
            UsergenderBox.Text = userDataGridView1.Rows[rowindex].Cells[8].Value.ToString();
            UsertypeBox.Text = userDataGridView1.Rows[rowindex].Cells[9].Value.ToString();
           
        }

        private void userUpdate_Click(object sender, EventArgs e)
        {


            if (userFirstNameBox.Text != "" && UserlastNameBox.Text != "" && userEmailBox.Text != "" && userNameBox.Text != ""
                && UserPassBox.Text != "" && UserContactBox.Text != "" && UserAdressBox.Text != "" && UsergenderBox.Text != ""
                && UsertypeBox.Text != "")
            {
                string loginIdname = LoginForm.loginName;

                UserBll adminId = dal.FindId(loginIdname);
                u.id = Convert.ToInt32(UserIdBox.Text);
                u.first_name = userFirstNameBox.Text;
                u.last_name = UserlastNameBox.Text;
                u.email = userEmailBox.Text;
                u.username = userNameBox.Text;
                u.password = UserPassBox.Text;
                u.contact = UserContactBox.Text;
                u.address = UserAdressBox.Text;
                u.gender = UsergenderBox.Text;
                u.user_type = UsertypeBox.Text;
                u.added_date = DateTime.Now;
                u.added_by = adminId.id;


                bool isSuccess = dal.Update(u);
                if (isSuccess = true)
                {
                    MessageBox.Show("User Successfully Updated");
                    DataTable dt = dal.Select();
                    userDataGridView1.DataSource = dt;
                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to Update User");
                }
              
            }
            else
            {
                MessageBox.Show("Please Fillup All Field");
            }


           
        }
       

        private void userDelete_Click(object sender, EventArgs e)
        {
            u.id = Convert.ToInt32(UserIdBox.Text);
            bool isDelete = dal.Delete(u);
            if (isDelete)
            {
                MessageBox.Show("User Successfully Deleted");
                DataTable dt = dal.Select();
                userDataGridView1.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Delete User");
            }
        }
    

        private void searchUser_TextChanged(object sender, EventArgs e)
        {
            String search = searchUser.Text;
            if (search != null)
            {
                DataTable dt = dal.Search(search);
                userDataGridView1.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                userDataGridView1.DataSource = dt;
            }
        }
        public void Clear()
        {
            UserIdBox.Text = " ";
            userFirstNameBox.Text = " ";
            UserlastNameBox.Text = " ";
            userEmailBox.Text = " ";
            userNameBox.Text = " ";
            UserPassBox.Text = " ";
            UserContactBox.Text = " ";
            UserAdressBox.Text = " ";
            UsergenderBox.Text = " ";
            UsertypeBox.Text = " ";

        }
    }
}
