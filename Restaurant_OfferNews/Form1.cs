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
            OrderForm aOrderForm = new OrderForm();
            aOrderForm.Show();
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
    }
}
