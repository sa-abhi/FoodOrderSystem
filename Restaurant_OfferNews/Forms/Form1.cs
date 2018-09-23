using Restaurant_OfferNews.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_OfferNews
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        //    ItemForm aForm = new ItemForm();
        //    aCustomerForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void orderDetailsButton_Click(object sender, EventArgs e)
        {
            OrderTable aOrderTable = new OrderTable();
            aOrderTable.Show();
        }

        private void customerFormButton_Click(object sender, EventArgs e)
        {
            CustomerForm aCustomerForm = new CustomerForm();
            aCustomerForm.Show();
        }

        private void itemFormButton_Click(object sender, EventArgs e)
        {
            ItemForm aItemForm = new ItemForm();
            aItemForm.Show();
        }

        private void orderFormButton_Click(object sender, EventArgs e)
        {
            OrderForm aOrderForm = new OrderForm();
            aOrderForm.Show();
        }
    }
}
