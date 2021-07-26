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
    class Deal_Cus_Dll
    {
        static string myconnecion = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        #region show all dealer and customer
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnecion);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM tbl_deal_cus";
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

        #region Insert values 
        public bool Insert(Deal_Cus_Bll dc)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnecion);
            try
            {
                string sql = "INSERT INTO tbl_deal_cus (type,name,email,contact,address,added_date,added_by) VALUES (@type,@name,@email,@contact,@address,@added_date,@added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@type", dc.type);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@added_date", dc.added_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);
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

        #region Update values
        public bool Update(Deal_Cus_Bll dc)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnecion);
            try
            {
                string sql = "UPDATE tbl_deal_cus SET type=@type,name=@name,email=@email,contact=@contact,address=@addressadded_date=@added_date," +
                             "added_by=@added_by WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@type", dc.type);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@added_date", dc.added_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);
                cmd.Parameters.AddWithValue("@id", dc.id);
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

        #region Delete value
        public bool Delete(Deal_Cus_Bll dc)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnecion);

            try
            {
                string sql = "DELETE FROM tbl_deal_cus WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", dc.id);
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

        #region Search Data 
        public DataTable Search(string keyword)
        {
            SqlConnection conn = new SqlConnection(myconnecion);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM tbl_deal_cus WHERE id LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%'";
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

        #region search for dealer and customer details
         public Deal_Cus_Bll SearchUserDealer(string keyword)
        {
            Deal_Cus_Bll dcb = new Deal_Cus_Bll();
            SqlConnection conn = new SqlConnection(myconnecion);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT name,email,contact,address FROM tbl_deal_cus WHERE id LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dcb.name = dt.Rows[0]["name"].ToString();
                    dcb.email = dt.Rows[0]["email"].ToString();
                    dcb.address = dt.Rows[0]["address"].ToString();
                    dcb.contact = dt.Rows[0]["contact"].ToString();
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

            return dcb;
        }
        #endregion

        #region search for product details
        public ProductBll Searchproduct(string keyword)
        {
            ProductBll pb = new ProductBll();
            SqlConnection conn = new SqlConnection(myconnecion);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT name,rate,qty FROM tbl_product WHERE id LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    pb.name = dt.Rows[0]["name"].ToString();
                    pb.rate = decimal.Parse(dt.Rows[0]["rate"].ToString());
                    pb.qty = decimal.Parse(dt.Rows[0]["qty"].ToString());
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

        #region get dealer or customer id
        public Deal_Cus_Bll Getid(string name)
        {
            Deal_Cus_Bll dcb = new Deal_Cus_Bll();
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(myconnecion);
            try
            {
                string sql = "SELECT id FROM tbl_deal_cus where name LIKE '%" + name + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count>0)
                {
                    dcb.id = int.Parse(dt.Rows[0]["id"].ToString());
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
            return dcb;
        }
        #endregion
    }
}
