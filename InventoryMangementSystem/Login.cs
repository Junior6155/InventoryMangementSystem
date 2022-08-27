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
    public partial class Login : Form
    {
        DBConnect dBCon = new DBConnect();
        public static string AttendantName;
        public Login()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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

        private void lbClear_MouseEnter(object sender, EventArgs e)
        {
            lbClear.ForeColor = Color.Red;
        }

        private void lbClear_MouseLeave(object sender, EventArgs e)
        {
            lbClear.ForeColor = Color.Black;
        }

        private void lbClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Username and Password", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

           

            if (cmbRole.SelectedIndex > -1)
            {
                if (cmbRole.SelectedItem.ToString() == "Admin")
                {
                    if (txtUsername.Text == "Admin" && txtPassword.Text == "Admin123")
                    {
                        Product product = new Product();
                        product.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("If you are an Admin, Please Enter the correct Id and Password", "Wrond Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    string selectQuery = "SELECT * FROM Attendant WHERE AttendantName='" + txtUsername.Text + "' AND AttendantPass='" + txtPassword.Text + "'";
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, dBCon.GetCon());
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        AttendantName = txtUsername.Text;
                        Order order = new Order();
                        order.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select Role", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            }

        }
    }
}
