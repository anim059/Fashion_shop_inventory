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
    class ProductDll
    {
        static string myconnection = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        #region Show all product
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnection);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM tbl_product";
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

        #region Add product
        public bool Insert(ProductBll p)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                string sql = "INSERT INTO tbl_product (name,category,description,rate,qty,added_date,added_by) VALUES (@name,@category,@description,@rate,@qty,@added_date,@added_by)";
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
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

        #region Update product
        public bool Update(ProductBll p)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                string sql = "UPDATE tbl_product SET name = @name, category = @category, description = @description," +
                             "rate = @rate, qty = @qty, added_date = @added_date, added_by = @added_by " +
                             "WHERE id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
                cmd.Parameters.AddWithValue("@id", p.id);
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

        #region Delete product
        public bool Delete(ProductBll p)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnection);

            try
            {
                string sql = "DELETE FROM tbl_product WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", p.id);
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

        #region Search product
        public DataTable Search(String keyword)
        {
            SqlConnection conn = new SqlConnection(myconnection);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM tbl_product WHERE id LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%'";
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

        #region get product current qty
        public decimal GetProductQty(int productId)
        {
            decimal qty = 0;
            SqlConnection conn = new SqlConnection(myconnection);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT qty FROM tbl_product WHERE id LIKE '%"+productId+"%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    qty = decimal.Parse(dt.Rows[0]["qty"].ToString());
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

            return qty;
        }
        #endregion

        #region Update product qty
        public bool UpdateQty(int productId,decimal Pdtqty)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                string sql = "UPDATE tbl_product SET qty=@qty WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@qty", Pdtqty);
                cmd.Parameters.AddWithValue("@id", productId);
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

        #region Increase product qty
        public bool IncreaseProductQty(int productId, decimal Pdtqty)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                decimal currentQty = GetProductQty(productId);

                decimal updated = currentQty + Pdtqty;

                isSuccess = UpdateQty(productId, updated);
                if (isSuccess == true)
                {
                    MessageBox.Show("Successfully increase");
                }
                else
                {
                    MessageBox.Show("Falid Descrase");
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

        #region Decrease product qty
        public bool DecreaseProductQty(int productId, decimal Pdtqty)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnection);
            try
            {
                decimal currentQty = GetProductQty(productId);

                if (Pdtqty < currentQty)
                {
                    decimal updated = currentQty - Pdtqty;
                    isSuccess = UpdateQty(productId, updated);
                }
                else
                {
                    MessageBox.Show("Value is too large");
                }
             
                if (isSuccess == true)
                {
                    MessageBox.Show("Successfully Decrease");
                }
                else
                {
                    MessageBox.Show("Falid Decrease");
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


    }
}
