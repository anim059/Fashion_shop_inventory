using Fashion_shop_billing.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fashion_shop_billing.DLL
{
    class transectionDetailsDll
    {
        static string myconnection = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        #region insert method for transaction details
        public bool Insert(transectiondetailBll tdb)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                string sql = "INSERT INTO tbl_transection_details (product_id,rate,qty,total,dea_cust_id,added_date,added_by) " +
                             "VALUES (@product_id,@rate,@qty,@total,@dea_cust_id,@added_date,@added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@product_id", tdb.product_id);
                cmd.Parameters.AddWithValue("@rate", tdb.rate);
                cmd.Parameters.AddWithValue("@qty", tdb.qty);
                cmd.Parameters.AddWithValue("@total", tdb.total);
                cmd.Parameters.AddWithValue("@dea_cust_id", tdb.dea_cust_id);
                cmd.Parameters.AddWithValue("@added_date", tdb.added_date);
                cmd.Parameters.AddWithValue("@added_by", tdb.added_by);
                conn.Open();

                int o = cmd.ExecuteNonQuery();
                if (o >0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region find product id
        public ProductBll Getid(string name)
        {
            ProductBll pb = new ProductBll();
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                string sql = "SELECT id FROM tbl_product where name LIKE '%" + name + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    pb.id = int.Parse(dt.Rows[0]["id"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return pb;
        }
        #endregion
    }
}
