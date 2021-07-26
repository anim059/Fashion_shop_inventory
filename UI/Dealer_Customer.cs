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
    public partial class Dealer_Customer : Form
    {
        public Dealer_Customer()
        {
            InitializeComponent();
        }
        Deal_Cus_Bll dcb = new Deal_Cus_Bll();
        Deal_Cus_Dll dcd = new Deal_Cus_Dll();
        userDll ud = new userDll();

        private void Dealer_Cus_close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Deal_CusAdd_Click(object sender, EventArgs e)
        {
            if (Deal_Cus_Name.Text!="" && Deal_Cus_Type.Text!=""&& Deal_Cus_Cnct.Text != "" && Deal_Cus_Email.Text != "" && Deal_Cus_Add.Text != "")
            {
                string username = LoginForm.loginName;
                UserBll userid = ud.FindId(username);

          
                dcb.name = Deal_Cus_Name.Text;
                dcb.type = Deal_Cus_Type.Text;
                dcb.email = Deal_Cus_Email.Text;
                dcb.contact = Deal_Cus_Cnct.Text;
                dcb.address = Deal_Cus_Add.Text;
                dcb.added_date = DateTime.Now;
                dcb.added_by = userid.id;

                bool isSucces = dcd.Insert(dcb);
                if(isSucces == true)
                {
                    MessageBox.Show("Successfully added");
                    Clear();
                    DataTable dt = dcd.Select();
                    Deal_cus_dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Failed to insert");
                    Clear();
                }

            }
            else
            {
                MessageBox.Show("Fill all the field");
            }
        }
        

        private void Deal_CusUpdate_Click(object sender, EventArgs e)
        {
            if (Deal_Cus_Name.Text != "" && Deal_Cus_Type.Text != "" && Deal_Cus_Cnct.Text != "" && Deal_Cus_Email.Text != "" && Deal_Cus_Add.Text != "")
            {
                string username = LoginForm.loginName;
                UserBll userid = ud.FindId(username);

                dcb.id = Convert.ToInt32(Deal_Cus_id.Text);
                dcb.name = Deal_Cus_Name.Text;
                dcb.type = Deal_Cus_Type.Text;
                dcb.email = Deal_Cus_Email.Text;
                dcb.contact = Deal_Cus_Cnct.Text;
                dcb.address = Deal_Cus_Add.Text;
                dcb.added_date = DateTime.Now;
                dcb.added_by = userid.id;

                bool isSucces = dcd.Update(dcb);
                if (isSucces == true)
                {
                    MessageBox.Show("Successfully added");
                    Clear();
                    DataTable dt = dcd.Select();
                    Deal_cus_dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Failed to update");
                    Clear();
                }

            }
            else
            {
                MessageBox.Show("Fill all the field");
            }
        }

        public void Clear()
        {
            Deal_Cus_id.Text = "";
            Deal_Cus_Name.Text = "";
            Deal_Cus_Type.Text = "";
            Deal_Cus_Email.Text = "";
            Deal_Cus_Cnct.Text = "";
            Deal_Cus_Add.Text = "";
            Deal_Cus_Search.Text = "";
        }

        private void Deal_cus_dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            int row = e.RowIndex;
            Deal_Cus_id.Text = Deal_cus_dataGridView1.Rows[row].Cells[0].Value.ToString();
            Deal_Cus_Type.Text = Deal_cus_dataGridView1.Rows[row].Cells[1].Value.ToString();
            Deal_Cus_Name.Text = Deal_cus_dataGridView1.Rows[row].Cells[2].Value.ToString();
            Deal_Cus_Email.Text = Deal_cus_dataGridView1.Rows[row].Cells[3].Value.ToString();
            Deal_Cus_Cnct.Text = Deal_cus_dataGridView1.Rows[row].Cells[4].Value.ToString();
            Deal_Cus_Add.Text = Deal_cus_dataGridView1.Rows[row].Cells[5].Value.ToString();
        }

        private void Deal_cus_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dealer_Customer_Load(object sender, EventArgs e)
        {
            DataTable dt = dcd.Select();
            Deal_cus_dataGridView1.DataSource = dt;
        }

        private void Deal_Cus_Search_TextChanged(object sender, EventArgs e)
        {
            string search = Deal_Cus_Search.Text;
            if (search != null)
            {
                DataTable dt = dcd.Search(search);
                Deal_cus_dataGridView1.DataSource = dt;
            }
            else
            {
                DataTable dt = dcd.Select();
                Deal_cus_dataGridView1.DataSource = dt;
            }
        }

        private void Deal_CusDelete_Click(object sender, EventArgs e)
        {
            dcb.id = Convert.ToInt32(Deal_Cus_id.Text);
            bool isSuccess = dcd.Delete(dcb);
            if(isSuccess == true)
            {

                MessageBox.Show("Successfully Deleted");
                DataTable dt = dcd.Select();
                Deal_cus_dataGridView1.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Delete");
            }

        }
    }
}
