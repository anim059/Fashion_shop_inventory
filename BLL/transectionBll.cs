using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_shop_billing.BLL
{
    class transectionBll
    {
        public int id { get; set; }
        public string type { get; set; }
        public int deal_cust_id { get; set; }
        public decimal grand_Total { get; set; }
        public DateTime transaction_date { get; set; }
        public decimal tax { get; set; }
        public decimal discount { get; set; }
        public int added_by { get; set; }

        public DataTable transectionDetails { get; set; }

    }
}
