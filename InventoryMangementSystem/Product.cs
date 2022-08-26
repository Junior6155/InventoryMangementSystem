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
            getTable();
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

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Product";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataPro.DataSource = table;
        }

        private void clear()
        {
            txtID.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtBB.Clear();
            txtBB.Clear();
            cmbcategory.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Product VALUES(" + txtID.Text + ", '" + txtName.Text + "', '" + txtPrice.Text + "', '" + txtBB.Text + "', '"+txtQty.Text+"', '"+cmbcategory.Text+"')";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
