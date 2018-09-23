using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Restaurant_OfferNews
{
    class GatewayClass
    {
        private SqlConnection con;
        private SqlCommand command;

        public GatewayClass()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["OfferNews"].ConnectionString);
        }

        public SqlConnection connect
        {
            get
            {
                return con;
            }
        }

        public SqlCommand cmd
        {
            get
            {
                command.Connection = con;
                return command;
            }
        }
    }
}
