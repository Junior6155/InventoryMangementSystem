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
    public partial class Order : Form
    {
        DBConnect dBCon = new DBConnect();
        public Order()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Seller";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataSeller.DataSource = table;
        }

        private void clear()
        {
            txtID.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtPhone.Clear();
            txtPass.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Product VALUES(" + txtID.Text + ", '" + txtName.Text + "', '" + txtAge.Text + "', '" + txtPhone.Text + "', '" + txtPass.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Seller Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
               getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Seller_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtName.Text == "" || txtAge.Text == "" || txtPhone.Text == "" || txtPass.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Seller SET SellerName='" + txtName.Text + "', SellerAge=" + txtAge.Text + ", SellerPhone=" + txtPhone.Text + ", SellerPass=" + txtPass.Text + "'WHERE SellerId=" + txtID.Text + "";
                    SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Seller Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dataSeller_Click(object sender, EventArgs e)
        {
            txtID.Text = dataSeller.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dataSeller.SelectedRows[0].Cells[1].Value.ToString();
            txtAge.Text = dataSeller.SelectedRows[0].Cells[2].Value.ToString();
            txtPhone.Text = dataSeller.SelectedRows[0].Cells[3].Value.ToString();
            txtPass.Text = dataSeller.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string deleteQuery = "DELETE FROM Seller WHERE SellerId=" + txtID.Text + "";
                    SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully", "Deleted Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }
            }
        }

        private void lbLogout_MouseEnter(object sender, EventArgs e)
        {
            lbLogout.ForeColor = Color.Red;
        }

        private void lbLogout_MouseLeave(object sender, EventArgs e)
        {
            lbLogout.ForeColor = Color.Black;
        }

        private void lbExit_MouseEnter(object sender, EventArgs e)
        {
            lbExit.ForeColor = Color.Red;
        }

        private void lbExit_MouseLeave(object sender, EventArgs e)
        {
            lbExit.ForeColor = Color.Black;
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void lbLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
            this.Hide();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
            this.Hide();
        }
    }
}
