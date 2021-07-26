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
using System.Transactions;
using System.Windows.Forms;

namespace Fashion_shop_billing.UI
{
    public partial class PurchaseAndSales : Form
    {
        public PurchaseAndSales()
        {
            InitializeComponent();
        }
        Deal_Cus_Dll dcd = new Deal_Cus_Dll();
        ProductDll pd = new ProductDll();
        userDll ud = new userDll();
        transectionDll trnd = new transectionDll();
        transectionDetailsDll trndal = new transectionDetailsDll();
        DataTable transactionDt = new DataTable();
        public decimal prevgrand;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dealer_Cus_close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PurchaseAndSales_Load(object sender, EventArgs e)
        {
            purchaseSaleLbl.Text = UserDashbroad.transactionType;
            transactionDt.Columns.Add("Productname");
            transactionDt.Columns.Add("Rate");
            transactionDt.Columns.Add("Qty");
            transactionDt.Columns.Add("Total");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Deal_cus_dtl_search_TextChanged(object sender, EventArgs e)
        {

            string search = Deal_cus_dtl_search.Text;
            if(search == "" )
            {
                deal_cus_name.Text = "";
                Deal_cus_email.Text = "";
                deal_cus_contct.Text = "";
                deal_cus_add.Text = "";
                return;
            }
 
                Deal_Cus_Bll dcb = dcd.SearchUserDealer(search);
                deal_cus_name.Text = dcb.name;
                Deal_cus_email.Text = dcb.email;
                deal_cus_contct.Text = dcb.contact;
                deal_cus_add.Text = dcb.address;
            
        }

        private void product_search_TextChanged(object sender, EventArgs e)
        {
            string searchp = product_search.Text;
            if (searchp == "")
            {
                product_name.Text = "";
                product_inven.Text = "";
                product_rate.Text = "";
                product_qty.Text = "";
                return;
            }

            ProductBll pb = dcd.Searchproduct(searchp);
            product_name.Text = pb.name;
            product_inven.Text = pb.qty.ToString();
            product_rate.Text = pb.rate.ToString();

        }

        private void Deal_CusAdd_Click(object sender, EventArgs e)
        {
           
            if (product_qty.Text != "" && product_name.Text != "" && product_rate.Text != "" && product_inven.Text !="")
            {
                string name = product_name.Text;
                decimal rate = decimal.Parse(product_rate.Text);
                decimal inent = decimal.Parse(product_inven.Text);
                decimal qty = decimal.Parse(product_qty.Text);
                decimal total = rate * qty;

                //calculate sub total
                decimal sum = decimal.Parse(cal_sub_ttl.Text);
                decimal subtotal = total + sum;
                cal_sub_ttl.Text = subtotal.ToString();
                cal_grd_total.Text = subtotal.ToString();

                if (name == "")
                {
                    MessageBox.Show("Select the product first");
                }
                else
                {
                    transactionDt.Rows.Add(name, rate, qty, total);
                    AddPrdctdataGridView1.DataSource = transactionDt;

                    product_search.Text = "";
                    product_qty.Text = "";
                    product_name.Text = "";
                    product_rate.Text = "00.0";
                    product_inven.Text = "00.0";
                }
            }
            else
            {
                MessageBox.Show("Enter qty value");
            }
           
        }

        private void cal_discount_TextChanged(object sender, EventArgs e)
        {
            if(cal_discount.Text != "")
            {
                int discount = int.Parse(cal_discount.Text);

                decimal grndtotalvalue = decimal.Parse(cal_grd_total.Text);
                decimal gndtotal = grndtotalvalue - (discount * grndtotalvalue) / 100;

                decimal grandtotal = decimal.Parse(cal_grd_total.Text);
                prevgrand = grandtotal;

                grandtotal =  gndtotal;
                cal_grd_total.Text = grandtotal.ToString();
            }
            else
            {
                if(cal_vat.Text != "")
                {
                    cal_grd_total.Text = prevgrand.ToString();
                }
                else
                {
                    decimal subtotal = decimal.Parse(cal_sub_ttl.Text);
                    cal_grd_total.Text = subtotal.ToString();
                }
            }
            

        }

        private void cal_vat_TextChanged(object sender, EventArgs e)
        {
            
            if (cal_vat.Text != "")
            {
                int vat = int.Parse(cal_vat.Text);

               

                if (cal_discount.Text != "")
                {
                    decimal grandtotal = decimal.Parse(cal_grd_total.Text);
                    decimal gndtotalvat = grandtotal + (vat * grandtotal) / 100;
                    prevgrand = grandtotal;
                    grandtotal = gndtotalvat;
                    cal_grd_total.Text = grandtotal.ToString();
                }
                else
                {
                    decimal grandtotal = decimal.Parse(cal_grd_total.Text);
                    decimal subtotalvat = decimal.Parse(cal_sub_ttl.Text);
                    decimal gndtotalvat = subtotalvat + (vat * subtotalvat) / 100;
                    prevgrand = grandtotal;
                    grandtotal = gndtotalvat;
                    cal_grd_total.Text = grandtotal.ToString();
                }
                             
            }
            else
            {
                if (cal_discount.Text != "")
                {
                    cal_grd_total.Text = prevgrand.ToString();
                }
                else
                {
                    decimal subtotal = decimal.Parse(cal_sub_ttl.Text);
                    cal_grd_total.Text = subtotal.ToString();
                }
            }
        }

        private void cal_paid_amt_TextChanged(object sender, EventArgs e)
        {
            if (cal_paid_amt.Text != "")
            {
                decimal paidamt = decimal.Parse(cal_paid_amt.Text);
                decimal grandtotal = decimal.Parse(cal_grd_total.Text);

                decimal retnamnt = paidamt - grandtotal;

                cal_return_amnt.Text = retnamnt.ToString();
            }
            else
            {
                cal_return_amnt.Text = "";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
                Deal_Cus_Dll dcd = new Deal_Cus_Dll();

                transectionBll trb = new transectionBll();
                trb.type = purchaseSaleLbl.Text;

                string uname = deal_cus_name.Text;
                Deal_Cus_Bll dcb = dcd.Getid(uname);

                trb.deal_cust_id = dcb.id;
                trb.transaction_date = DateTime.Now;
                trb.grand_Total = Math.Round(decimal.Parse(cal_grd_total.Text), 2);
                trb.tax = decimal.Parse(cal_vat.Text);
                trb.discount = decimal.Parse(cal_discount.Text);

                string loginname = LoginForm.loginName;
                UserBll adminid = ud.FindId(loginname);
                trb.added_by = adminid.id;
                trb.transectionDetails = transactionDt;

                bool success = false;

                using (TransactionScope scope = new TransactionScope())
                {
                    int transactionId = -1;
                    bool w = trnd.Insert(trb, out transactionId);
                    for (int i = 0; i < transactionDt.Rows.Count; i++)
                    {
                        transectiondetailBll tdb = new transectiondetailBll();
                        string pname = transactionDt.Rows[i][0].ToString();
                        ProductBll pb = trndal.Getid(pname);

                        tdb.product_id = pb.id;
                        tdb.rate = decimal.Parse(transactionDt.Rows[i][1].ToString());
                        tdb.qty = decimal.Parse(transactionDt.Rows[i][2].ToString());
                        tdb.total = Math.Round(decimal.Parse(transactionDt.Rows[i][3].ToString()), 2);
                        tdb.dea_cust_id = dcb.id;
                        tdb.added_by = adminid.id;
                        tdb.added_date = DateTime.Now;
                        bool y=false;
                        string transactionType = purchaseSaleLbl.Text;
                        if (transactionType == "Purchase")
                        {
                             y = pd.IncreaseProductQty(tdb.product_id, tdb.qty);
                        }
                         else if (transactionType == "Sale")
                        {
                            y = pd.DecreaseProductQty(tdb.product_id, tdb.qty);
                        }

                        bool s = trndal.Insert(tdb);
                        success = w && s && y;

                    }
                    if (success)
                    {
                        scope.Complete();
                        MessageBox.Show("Successfully Save");
                        AddPrdctdataGridView1.DataSource = null;
                        AddPrdctdataGridView1.Rows.Clear();

                        Deal_cus_dtl_search.Text = "";
                        deal_cus_name.Text = "";
                        deal_cus_add.Text = "";
                        deal_cus_contct.Text = "";
                        Deal_cus_email.Text = "";
                        product_name.Text = "";
                        product_search.Text = "";
                        product_qty.Text = "0";
                        product_inven.Text = "0";
                        product_rate.Text = "0";
                        cal_discount.Text = "0";
                        cal_vat.Text = "0";
                        cal_grd_total.Text = "0";
                        cal_paid_amt.Text = "0";
                        cal_return_amnt.Text = "0";
                        cal_sub_ttl.Text = "0";


                    }
                    else
                    {
                        MessageBox.Show("Failed Save");
                    }

                }
            

        }
    }
}
