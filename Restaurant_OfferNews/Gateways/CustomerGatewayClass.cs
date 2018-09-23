using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_OfferNews.Class
{
    class CustomerGatewayClass : GatewayClass
    {
        public void CustomerSave(CustomerClass aCustomerClass)
        {
            connect.Open();
            string insertQuery = string.Format("INSERT INTO CustomerInfo VALUES('{0}', '{1}')", aCustomerClass.Name, aCustomerClass.Phone);
            SqlCommand comm = new SqlCommand(insertQuery, connect);
            comm.ExecuteReader();
            connect.Close();
        }
    }
}
