using Restaurant_OfferNews.Class;
using Restaurant_OfferNews.Tables;
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

namespace Restaurant_OfferNews.Forms
{
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);

        private void itemFormCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Form1 aForm1 = new Form1();
            aForm1.Show();
        }

        private void itemTableButton_Click(object sender, EventArgs e)
        {
            ItemTable aItemTable = new ItemTable();
            aItemTable.Show();
            this.Hide();            
        }

        private void customrFormButton_Click(object sender, EventArgs e)
        {
            CustomerForm aCustomerForm = new CustomerForm();
            aCustomerForm.Show();
        }

        private void orderFormButton_Click(object sender, EventArgs e)
        {
            OrderForm aOrderForm = new OrderForm();
            aOrderForm.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
             if (itemNameTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Item Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                itemNameTextBox.Focus();
                return;
            }
            ItemClass aItemClass = new ItemClass();
            ItemGatewayClass aItemGatewayClass = new ItemGatewayClass();
            aItemClass.Name = itemNameTextBox.Text;
            aItemGatewayClass.ItemSave(aItemClass);
            //reset();
            MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (itemIdLabel.Text == "")
            {
                MessageBox.Show("Update value missing", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //countryIdLabel.Focus();
                //return;
            }
            else
            {
                ItemClass aItemClass = new ItemClass();
                aItemClass.ItemId = Convert.ToInt32(itemIdLabel.Text);
                aItemClass.Name = itemNameTextBox.Text;
                string updateQuery = "UPDATE ItemInfo SET Name='" + aItemClass.Name + "' WHERE ItemID='" + aItemClass.ItemId + "'";
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
            if (itemIdLabel.Text == "")
            {
                MessageBox.Show("Update value missing", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //countryIdLabel.Focus();
                //return;
            }
            else
            {
                ItemClass aItemClass = new ItemClass();
                aItemClass.ItemId = Convert.ToInt32(itemIdLabel.Text);
                aItemClass.Name = itemNameTextBox.Text;
                string deleteQuery = "DELETE ItemInfo WHERE ItemID='" + aItemClass.ItemId + "'";
                SqlCommand command = new SqlCommand(deleteQuery, con);
                con.Open();
                command.ExecuteReader();
                con.Close();
                //reset();
                MessageBox.Show("Data Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
