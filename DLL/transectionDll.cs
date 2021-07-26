using Fashion_shop_billing.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fashion_shop_billing.DLL
{
    class transectionDll
    {
        static string myconnection = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        #region insert value
        public bool Insert(transectionBll tb,out int transectionId)
        {
            bool isSuccess = false;
            transectionId = -1;
            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                string sql = "INSERT INTO tbl_transection (type,deal_cust_id,grand_Total,transaction_date,tax,discount,added_by) " +
                             "VALUES (@type,@deal_cust_id,@grand_Total,@transaction_date,@tax,@discount,@added_by); SELECT @@IDENTITY";
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.Parameters.AddWithValue("@type", tb.type);
                cmd.Parameters.AddWithValue("@deal_cust_id", tb.deal_cust_id);
                cmd.Parameters.AddWithValue("@grand_Total", tb.grand_Total);
                cmd.Parameters.AddWithValue("@transaction_date", tb.transaction_date);
                cmd.Parameters.AddWithValue("@tax", tb.tax);
                cmd.Parameters.AddWithValue("@discount", tb.discount);
                cmd.Parameters.AddWithValue("@added_by", tb.added_by);
                conn.Open();

                object o = cmd.ExecuteScalar();
                if (o != null)
                {
                    transectionId = int.Parse(o.ToString());
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
        #region
        #endregion
        #region
        #endregion
        #region
        #endregion
    }
}
