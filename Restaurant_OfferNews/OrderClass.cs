using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_OfferNews
{
    class OrderClass
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }

        public int ItemId { get; set; }

        public string ItemName { get; set; }

        public int Qty { get; set; }

        public double UnitePrice { get; set; }

        public DateTime Date { get; set; }

        public double Bill { get; set; }

        
    }
}
