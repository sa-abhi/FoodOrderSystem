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

        public int Cust_ID { get; set; }

        public int Item_ID { get; set; }
        public int Quantity { get; set; }

        public double Unit_Price { get; set; }
        public double Bill { get; set; }

        public DateTime Date { get; set; }

      
      
    }
}
