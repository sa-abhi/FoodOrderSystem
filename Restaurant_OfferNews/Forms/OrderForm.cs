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

namespace Restaurant_OfferNews
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Form1 aForm1 = new Form1();
            aForm1.Show();
        }

        private void customrFormButton_Click(object sender, EventArgs e)
        {
            CustomerForm aCustomerForm = new CustomerForm();
            aCustomerForm.Show();
        }

        private void itemFormButton_Click(object sender, EventArgs e)
        {
            ItemForm aItemForm = new ItemForm();
            aItemForm.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (qtyTextBox.Text == "" || unitPriceTextBox.Text == "" || billTextBox.Text == "")
            {
                MessageBox.Show("Field value is missing", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                        
            }
            OrderClass aOrderClass = new OrderClass();
            OrderGatewayClass aOrderGatewayClass = new OrderGatewayClass();
            aOrderClass.Cust_ID = Convert.ToInt32(customer_comboBox.SelectedValue);
            aOrderClass.Item_ID = Convert.ToInt32(item_ComboBox.SelectedValue);
            aOrderClass.Quantity = Convert.ToInt32(qtyTextBox.Text);
            aOrderClass.Unit_Price = Convert.ToInt32(unitPriceTextBox.Text);
            aOrderClass.Bill = Convert.ToInt32(billTextBox.Text);
            aOrderClass.Date = Convert.ToDateTime(txt_Date.Text);
            
            aOrderGatewayClass.OrderSave(aOrderClass);
            //reset();
            MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (orderIdLabel.Text == "")
            {
                MessageBox.Show("Update value missing", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //countryIdLabel.Focus();
                //return;
            }
            else
            {
                OrderClass aOrderClass = new OrderClass();
                aOrderClass.OrderId = Convert.ToInt32(orderIdLabel.Text);
               // aOrderClass.Date = Convert.ToDateTime(dateTextBox.Text);
                aOrderClass.Quantity = Convert.ToInt32(qtyTextBox.Text);
                aOrderClass.Unit_Price = Convert.ToInt32(unitPriceTextBox.Text);
                aOrderClass.Bill = Convert.ToInt32(billTextBox.Text);
                string updateQuery = "UPDATE OrderInfo SET Date='" + aOrderClass.Date + "', Quantity='" + aOrderClass.Quantity + "',  Unit_Price='" + aOrderClass.Unit_Price + "',  Bill='" + aOrderClass.Bill + "' WHERE OrderID='" + aOrderClass.OrderId + "'";
                SqlCommand command = new SqlCommand(updateQuery, con);
                con.Open();
                command.ExecuteReader();
                con.Close();
                //reset();
                MessageBox.Show("Data Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (orderIdLabel.Text == "")
            {
                MessageBox.Show("Delete value missing", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //countryIdLabel.Focus();
                //return;
            }
            else
            {
                OrderClass aOrderClass = new OrderClass();
                aOrderClass.OrderId = Convert.ToInt32(orderIdLabel.Text);
                //aOrderClass.Date = Convert.ToDateTime(dateTextBox.Text);
                aOrderClass.Quantity = Convert.ToInt32(qtyTextBox.Text);
                aOrderClass.Unit_Price = Convert.ToInt32(unitPriceTextBox.Text);
                aOrderClass.Bill = Convert.ToInt32(billTextBox.Text);
                string deleteQuery = "DELETE OrderInfo WHERE OrderID='" + aOrderClass.OrderId + "'";
                SqlCommand command = new SqlCommand(deleteQuery, con);
                con.Open();
                command.ExecuteReader();
                con.Close();
                //reset();
                MessageBox.Show("Data Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void customerIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void orderTableButton_Click(object sender, EventArgs e)
        {
            OrderTable aOrderTable = new OrderTable();
            aOrderTable.Show();
            this.Hide();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDBDataSet3.ItemInfo' table. You can move, or remove it, as needed.
            this.itemInfoTableAdapter2.Fill(this.restaurantDBDataSet3.ItemInfo);
            // TODO: This line of code loads data into the 'restaurantDBDataSet2.ItemInfo' table. You can move, or remove it, as needed.
            this.itemInfoTableAdapter1.Fill(this.restaurantDBDataSet2.ItemInfo);
            // TODO: This line of code loads data into the 'restaurantDBDataSet1.ItemInfo' table. You can move, or remove it, as needed.
            this.itemInfoTableAdapter.Fill(this.restaurantDBDataSet1.ItemInfo);
            //dateTextBox.Text = DateTime.Now.ToShortDateString();
            // TODO: This line of code loads data into the 'restaurantDBDataSet.CustomerInfo' table. You can move, or remove it, as needed.
            this.customerInfoTableAdapter.Fill(this.restaurantDBDataSet.CustomerInfo);
            // Fill_ItemListBox();
            txt_Date.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTextBox_TextChanged(object sender, EventArgs e)
        {
            //string CurrentDate = System.DateTime.Now.Date.ToString();
            //dateTextBox.Show(CurrentDate);
        }

        //private void btn_ItemAdd_Click(object sender, EventArgs e)
        //{
        //    //con.Open();
        //    //SqlCommand cmd = con.CreateCommand();
        //    //cmd.CommandType = CommandType.Text;
        //    //cmd.CommandText = "select * from ItemInfo where Name='" + item_List.SelectedItem.ToString() + "'";
        //    //cmd.ExecuteNonQuery();
        //    //DataTable dt = new DataTable();
        //    //SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    //da.Fill(dt);
        //    //if(item_List.SelectedIndex != -1)
        //    //{
        //    //    foreach (DataRow dr in dt.Rows)
        //    //    {
        //    //        txt_order.Text = dr["Name"].ToString() + " , " +  ;
        //    //    }
        //    //}

        //    //con.Close();
        //    string selectedItem;
        //    if (item_List.SelectedIndex != -1)
        //    {
        //        selectedItem = item_List.SelectedItem.ToString();
        //            txt_order.Text =selectedItem;
        //            //txt_order.Text = "select * from ItemInfo where Name='" + item_List.SelectedItem.ToString() + "'";
        //    }
        //}

        //void Fill_ItemListBox()
        //{
        //    item_List.Items.Clear();
        //    con.Open();
        //    SqlCommand cmd = con.CreateCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "select Name from ItemInfo";
        //    cmd.ExecuteNonQuery();
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(dt);
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        item_List.Items.Add(dr["Name"].ToString());
        //    }
        //    con.Close();
        //}
        private void item_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void billTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void unitPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            int totalbill = Convert.ToInt32(qtyTextBox.Text) * Convert.ToInt32(unitPriceTextBox.Text);
            billTextBox.Text = totalbill.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void txt_order_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Date_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
