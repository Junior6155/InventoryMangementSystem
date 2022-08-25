using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryMangementSystem
{
    public partial class Category : Form
    {
        DBConnect dBCon = new DBConnect();
        public Category()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataCat.DataSource = table;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Category VALUES(" + txtID.Text + ",'" + txtName.Text + "','" + txtDesc.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery,dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully", "Done");
                dBCon.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);             
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Category_Load(object sender, EventArgs e)
        {
            getTable();
        }
    }
}
