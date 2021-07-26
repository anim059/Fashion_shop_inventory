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
    class loginFormDll
    {
        static string myconnection = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        #region Check user of login form
        public bool CheckUser(loginFromBll d)
        {
            bool isLogin = false;
            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                string sql = "SELECT * from tbl_user WHERE username=@username AND password=@password AND user_type=@user_type";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username",d.username);
                cmd.Parameters.AddWithValue("@password", d.password);
                cmd.Parameters.AddWithValue("@user_type", d.user_type);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    isLogin = true;
                }
                else
                {
                    isLogin = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isLogin;
        }
        #endregion
    }
}
