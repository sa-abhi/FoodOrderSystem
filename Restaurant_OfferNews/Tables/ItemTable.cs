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
    public partial class ItemTable : Form
    {
        public ItemTable()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);

        private void ItemTable_Load(object sender, EventArgs e)
        {
            string retrieveQuery = "SELECT * FROM ItemInfo";
            SqlCommand command = new SqlCommand(retrieveQuery, con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<ItemClass> aItemClassList = new List<ItemClass>();
            while (reader.Read())
            {
                ItemClass aItemClass = new ItemClass();
                aItemClass.ItemId = Convert.ToInt32(reader["ItemID"].ToString());
                aItemClass.Name = reader["Name"].ToString();

                aItemClassList.Add(aItemClass);
            }
            itemDataGridView.DataSource = aItemClassList;
            con.Close();
        }

        private void itemDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = itemDataGridView.SelectedRows[0];
            this.Hide();
            ItemForm aItemForm = new ItemForm();
            aItemForm.itemNameTextBox.Text = dr.Cells["Name"].Value.ToString();
            aItemForm.itemIdLabel.Text = dr.Cells["ItemID"].Value.ToString();
            aItemForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
