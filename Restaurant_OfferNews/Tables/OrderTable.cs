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

namespace Restaurant_OfferNews
{
    public partial class OrderTable : Form
    {
        public OrderTable()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OrderTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDBDataSet4.OrderInfo' table. You can move, or remove it, as needed.
            this.orderInfoTableAdapter.Fill(this.restaurantDBDataSet4.OrderInfo);
            string retrieveQuery = "SELECT * FROM OrderInfo";
            SqlCommand command = new SqlCommand(retrieveQuery, con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<OrderClass> aOrderClassList = new List<OrderClass>();
            while (reader.Read())
            {
                OrderClass aOrderClass = new OrderClass();
                aOrderClass.OrderId = Convert.ToInt32(reader["OrderID"].ToString());
                aOrderClass.Cust_ID = Convert.ToInt32(reader["Cust_ID"]);
                aOrderClass.Item_ID = Convert.ToInt32(reader["Item_ID"]);
                aOrderClass.Date =Convert.ToDateTime(reader["Date"].ToString());
                aOrderClass.Quantity= Convert.ToInt32(reader["Quantity"].ToString());
                aOrderClass.Unit_Price = Convert.ToInt32(reader["Unit_Price"].ToString());
                aOrderClass.Bill = Convert.ToInt32(reader["Bill"].ToString());

                aOrderClassList.Add(aOrderClass);
            }
            orderDetailsDataGridView.DataSource = aOrderClassList;
            con.Close();
        }

        private void orderDetailsDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = orderDetailsDataGridView.SelectedRows[0];
            this.Hide();
            OrderForm aOrderForm = new OrderForm();
            //aOrderForm.orderIdLabel.Text = dr.Cells["OrderID"].Value.ToString();
            aOrderForm.qtyTextBox.Text = dr.Cells["Quantity"].Value.ToString();
            aOrderForm.unitPriceTextBox.Text = dr.Cells["Unit_Price"].Value.ToString();
            aOrderForm.billTextBox.Text = dr.Cells["Bill"].Value.ToString();

            aOrderForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OrderForm aOrderForm = new OrderForm();
            this.Hide();
            aOrderForm.Show();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Form1 aForm1 = new Form1();
            this.Hide();
            //aForm1.Show();
        }
    }
}
