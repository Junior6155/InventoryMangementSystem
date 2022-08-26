using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMangementSystem
{
    public partial class Product : Form
    {
        DBConnect dBCon = new DBConnect();
        public Product()
        {
            InitializeComponent();
        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
            this.Hide();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            getCategory();
        }

        private void getCategory()
        {
            string selectQuerry = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbcategory.DataSource = table;
            cmbcategory.ValueMember = "CatName";
            cmbSearch.DataSource = table;
            cmbSearch.ValueMember = "CatName";
        }
    }
}
