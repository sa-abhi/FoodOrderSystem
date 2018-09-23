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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void customerNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerPhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cutomerIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void customerFormCloseButton_Click(object sender, EventArgs e)
        {
            Form1 aForm1 = new Form1();
            this.Close();
            //aForm1.Show();        
            //Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customerTableButton_Click(object sender, EventArgs e)
        {
            CustomerTable aCustomerTable = new CustomerTable();
            aCustomerTable.Show();
            this.Hide();
        }

        private void itemFormButton_Click(object sender, EventArgs e)
        {
            ItemForm aItemForm = new ItemForm();
            aItemForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OrderForm aOrderForm = new OrderForm();
            aOrderForm.Show();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Form1 aForm1 = new Form1();
            aForm1.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (customerNameTextBox.Text == ""  || customerPhoneTextBox.Text=="")
            {
                MessageBox.Show("Field value is missing", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customerNameTextBox.Focus();
                customerPhoneTextBox.Focus();
                return;
            }
            CustomerClass aCustomerClass = new CustomerClass();
            CustomerGatewayClass aCustomerGatewayClass = new CustomerGatewayClass();
            aCustomerClass.Name = customerNameTextBox.Text;
            aCustomerClass.Phone = customerPhoneTextBox.Text;
            aCustomerGatewayClass.CustomerSave(aCustomerClass);
            //reset();
            MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (cutomerIdLabel.Text == "")
            {
                MessageBox.Show("Update value missing", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //countryIdLabel.Focus();
                //return;
            }
            else
            {
                CustomerClass aCustomerClass = new CustomerClass();
                aCustomerClass.CustomerId = Convert.ToInt32(cutomerIdLabel.Text);
                aCustomerClass.Name = customerNameTextBox.Text;
                aCustomerClass.Phone = customerPhoneTextBox.Text;
                string updateQuery = "UPDATE CustomerInfo SET Name='" + aCustomerClass.Name + "',  Phone='" + aCustomerClass.Phone + "' WHERE CustomrID='" + aCustomerClass.CustomerId + "'";
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
            if (cutomerIdLabel.Text == "")
            {
                MessageBox.Show("Delete value missing", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //countryIdLabel.Focus();
                //return;
            }
            else
            {
                CustomerClass aCustomerClass = new CustomerClass();
                aCustomerClass.CustomerId = Convert.ToInt32(cutomerIdLabel.Text);
                aCustomerClass.Name = customerNameTextBox.Text;
                aCustomerClass.Phone = customerPhoneTextBox.Text;
                string deleteQuery = "DELETE CustomerInfo WHERE CustomerID='" + aCustomerClass.CustomerId + "'";
                SqlCommand command = new SqlCommand(deleteQuery, con);
                con.Open();
                command.ExecuteReader();
                con.Close();
                //reset();
                MessageBox.Show("Data Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
