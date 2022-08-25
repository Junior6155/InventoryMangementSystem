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
                MessageBox.Show("Category Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try 
            {
                if (txtID.Text == "" || txtName.Text == "" || txtDesc.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Category SET CatName = '" + txtName.Text + "', CatDes= '" + txtDesc.Text + "'WHERE CatId= " + txtID.Text + "";
                    SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataCat_Click(object sender, EventArgs e)
        {
            txtID.Text = dataCat.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dataCat.SelectedRows[0].Cells[1].Value.ToString();
            txtDesc.Text = dataCat.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void clear()
        {
            txtID.Clear();
            txtName.Clear();
            txtDesc.Clear();
        }

        private void btnDelele_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM Category WHERE CatId= " + txtID.Text + "";
                SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbExit_MouseEnter(object sender, EventArgs e)
        {
            lbExit.ForeColor = Color.Red;
        }

        private void lbExit_MouseLeave(object sender, EventArgs e)
        {
            lbExit.ForeColor = Color.Black;
        }
    }
}
