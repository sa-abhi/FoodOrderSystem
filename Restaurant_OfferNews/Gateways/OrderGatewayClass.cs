using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_OfferNews
{
    class OrderGatewayClass:GatewayClass
    {
        public void OrderSave(OrderClass aOrderClass)
        {
            connect.Open();
            string insertQuery = string.Format("INSERT INTO OrderInfo VALUES({0},{1},{2},{3},{4},'{5}')", aOrderClass.Cust_ID,aOrderClass.Item_ID, aOrderClass.Quantity,aOrderClass.Unit_Price, aOrderClass.Bill, aOrderClass.Date);
            SqlCommand comm = new SqlCommand(insertQuery, connect);
            comm.ExecuteNonQuery();
            connect.Close();
        }
    }
}
