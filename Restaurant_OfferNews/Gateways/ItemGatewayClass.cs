using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_OfferNews.Class
{
    class ItemGatewayClass: GatewayClass
    {
        public void ItemSave(ItemClass aItemClass)
        {
            connect.Open();
            string insertQuery = string.Format("INSERT INTO ItemInfo VALUES('{0}')", aItemClass.Name);
            SqlCommand comm = new SqlCommand(insertQuery, connect);
            comm.ExecuteReader();
            connect.Close();
        }
    }
}
