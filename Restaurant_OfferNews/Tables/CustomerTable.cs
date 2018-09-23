using Restaurant_OfferNews.Class;
using Restaurant_OfferNews.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_OfferNews.Tables
{
    public partial class CustomerTable : Form
    {
        public CustomerTable()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);

        private void CustomerTable_Load(object sender, EventArgs e)
        {
            string retrieveQuery = "SELECT * FROM CustomerInfo";
            SqlCommand command = new SqlCommand(retrieveQuery, con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<CustomerClass> aCustomerClassList = new List<CustomerClass>();
            while (reader.Read())
            {
                CustomerClass aCustomerClass = new CustomerClass();
                aCustomerClass.CustomerId = Convert.ToInt32(reader["CustomerID"].ToString());
                aCustomerClass.Name = reader["Name"].ToString();
                aCustomerClass.Phone = reader["Phone"].ToString();

                aCustomerClassList.Add(aCustomerClass);
            }
            customerDataGridView.DataSource = aCustomerClassList;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customerDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = customerDataGridView.SelectedRows[0];
            this.Hide();
            CustomerForm aCustomerForm = new CustomerForm();
            aCustomerForm.customerNameTextBox.Text = dr.Cells["Name"].Value.ToString();
            aCustomerForm.customerPhoneTextBox.Text = dr.Cells["Phone"].Value.ToString();
            aCustomerForm.cutomerIdLabel.Text = dr.Cells["CustomerID"].Value.ToString();
            aCustomerForm.Show();
        }


    }
}
