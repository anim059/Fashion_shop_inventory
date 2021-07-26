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
    class userDll
    {
        static string myconnection = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        #region Select data from database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnection);
            DataTable dt = new DataTable();
            try
            {
                String sql = "Select * from tbl_user";
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
        #region insert data into tble_user
        public bool Insert(UserBll U)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                String sql = "INSERT INTO tbl_user (first_name,last_name,email,username,password,contact,address,gender,user_type,added_date,added_by) VALUES (@first_name,@last_name,@email,@username,@password,@contact,@address,@gender,@user_type,@added_date,@added_by)";
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.Parameters.AddWithValue("@first_name", U.first_name);
                cmd.Parameters.AddWithValue("@last_name", U.last_name);
                cmd.Parameters.AddWithValue("@email", U.email);
                cmd.Parameters.AddWithValue("@username", U.username);
                cmd.Parameters.AddWithValue("@password", U.password);
                cmd.Parameters.AddWithValue("@contact", U.contact);
                cmd.Parameters.AddWithValue("@address", U.address);
                cmd.Parameters.AddWithValue("@gender", U.gender);
                cmd.Parameters.AddWithValue("@user_type", U.user_type);
                cmd.Parameters.AddWithValue("@added_date", U.added_date);
                cmd.Parameters.AddWithValue("@added_by", U.added_by);
                conn.Open();

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
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
            return isSuccess;
        }
        #endregion
        #region Update data into user table
        public bool Update(UserBll U)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnection);

            try
            {
                String sql = "UPDATE tbl_user SET first_name=@first_name,last_name=@last_name,email=@email,username=@username,password=@password,contact=@contact,address=@address,gender=@gender,user_type=@user_type,added_date=@added_date,added_by=@added_by WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@first_name", U.first_name);
                cmd.Parameters.AddWithValue("@last_name", U.last_name);
                cmd.Parameters.AddWithValue("@email", U.email);
                cmd.Parameters.AddWithValue("@username", U.username);
                cmd.Parameters.AddWithValue("@password", U.password);
                cmd.Parameters.AddWithValue("@contact", U.contact);
                cmd.Parameters.AddWithValue("@address", U.address);
                cmd.Parameters.AddWithValue("@gender", U.gender);
                cmd.Parameters.AddWithValue("@user_type", U.user_type);
                cmd.Parameters.AddWithValue("@added_date", U.added_date);
                cmd.Parameters.AddWithValue("@added_by", U.added_by);
                cmd.Parameters.AddWithValue("@id", U.id);
                conn.Open();

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
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
            return isSuccess;
        }
        #endregion
        #region Delete data from table
        public bool Delete(UserBll U)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnection);

            try
            {
                string sql = "DELETE FROM tbl_user WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", U.id);
                conn.Open();

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
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
        #region Data search from table
        public DataTable Search(String keyword)
        {
            SqlConnection conn = new SqlConnection(myconnection);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM tbl_user WHERE id LIKE '%"+keyword+"%' OR username LIKE '%"+keyword+"%'";
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        #endregion
        #region Find admin id from name
        public UserBll FindId( string username)
        {
            UserBll u = new UserBll();
            SqlConnection conn = new SqlConnection(myconnection);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT id FROM tbl_user WHERE username LIKE '" + username + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    u.id = int.Parse(dt.Rows[0]["id"].ToString());
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
            return u;
        }
        #endregion
    }
}
