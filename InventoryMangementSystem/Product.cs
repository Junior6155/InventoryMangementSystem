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
            try
            {
                if (txtID.Text==""|| txtName.Text==""||txtPrice.Text==""||txtBB.Text==""||txtQty.Text=="")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Ptoduct SET ProdName='" + txtName.Text + "', ProdPrice=" + txtPrice.Text + ", ProdQty=" + txtQty.Text + ", ProdBB=" + txtBB.Text + ", ProdCat=" + cmbcategory.Text + "'WHERE ProdId=" + txtID.Text + "";
                    SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dataPro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataPro.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dataPro.SelectedRows[0].Cells[1].Value.ToString();
            txtPrice.Text = dataPro.SelectedRows[0].Cells[2].Value.ToString();
            txtQty.Text = dataPro.SelectedRows[0].Cells[3].Value.ToString();
            txtBB.Text = dataPro.SelectedRows[0].Cells[4].Value.ToString();
            cmbcategory.SelectedValue = dataPro.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string deleteQuery = "DELETE FROM Product WHERE ProdId=" + txtID.Text + "";
                SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Product Deleted Successfully", "Deleted Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void cmbSearch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuerry = "SELECT * FROM Product WHERE ProdCat='" + cmbSearch.SelectedValue.ToString() + "'"; ;
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataPro.DataSource = table;
        }

        private void lbExit_Click(object sender, EventArgs e)
        {

        }

        private void lbExit_MouseEnter(object sender, EventArgs e)
        {
            lbExit.ForeColor = Color.Red;
        }

        private void lbExit_MouseLeave(object sender, EventArgs e)
        {
            lbExit.ForeColor = Color.Black;
        }

        private void lbLogout_MouseEnter(object sender, EventArgs e)
        {
            lbLogout.ForeColor = Color.Red;
        }

        private void lbLogout_MouseLeave(object sender, EventArgs e)
        {
            lbLogout.ForeColor = Color.Black;
        }

        private void lbLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
