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
    class CategoryDll
    {

        static string myconnection = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        #region show all Category product
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnection);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_category";
                SqlCommand cmd = new SqlCommand(sql, conn);
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
        #region Add Category
        public bool Insert(CategoryBll c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                string sql = "INSERT INTO tbl_category (title,description,added_by,added_date) VALUES (@title,@description,@added_by,@added_date)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("title", c.title);
                cmd.Parameters.AddWithValue("description", c.description);
                cmd.Parameters.AddWithValue("added_by", c.added_by);
                cmd.Parameters.AddWithValue("added_date", c.added_date);
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
        #region Update Category 
        public bool Update(CategoryBll c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnection);

            try
            {
                String sql = "UPDATE tbl_category SET title=@title,description=@description,added_by=@added_by,added_date=@added_date WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@id", c.id);
               
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
        #region Delete Category 
        public bool Delect(CategoryBll c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnection);

            try
            {
                string sql = "DELETE FROM tbl_category WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", c.id);
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
        #region Search Category 
        public DataTable Search(string c)
        {
            SqlConnection conn = new SqlConnection(myconnection);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM tbl_category WHERE title LIKE '" + c + "' OR id LIKE '" + c + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
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
       
    }
}
