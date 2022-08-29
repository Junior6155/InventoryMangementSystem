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
using DGVPrinterHelper;

namespace InventoryMangementSystem
{
    public partial class Order : Form
    {
        DBConnect dBCon = new DBConnect();      
        DGVPrinter printer = new DGVPrinter(); 
        public Order()
        {
            InitializeComponent();
        }

        private void getCategory()
        {
            string selectQuerry = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbCat.DataSource = table;
            cmbCat.ValueMember = "CatName";
          }

        private void getTable()
        {
            string selectQuerry = "SELECT ProdName, ProdPrice FROM Product";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataList.DataSource = table;
        }

        private void getOrderTable()
        {
            string selectQuerry = "SELECT * FROM Bill";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataSelling.DataSource = table;
        }
       

        private void dataSelling_Click(object sender, EventArgs e)
        {
            txtName.Text = dataSelling.SelectedRows[0].Cells[0].Value.ToString();
            txtPrice.Text = dataSelling.SelectedRows[0].Cells[1].Value.ToString();  
        }

        int grandTotal = 0, n = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Bill VALUES(" + txtId.Text + ", '" + lbAttendant.Text + "', '" + lbDate.Text + "',  " + grandTotal.ToString() + ")";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Order Added Successfully", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getOrderTable();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Order_Load(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Today.ToShortDateString();
            lbAttendant.Text = Login.AttendantName;
            getTable();
            getCategory();
            getOrderTable();
        }

        //Used DGVPrinter from Github
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printer.Title = "Shoprite Ghana Limited";
            printer.SubTitle = String.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Thank you for shopping with us";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataList);
        }

        private void lbLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void cmbCat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuerry = "SELECT ProdName, ProdPrice FROM Product WHERE ProdCat='" + cmbCat.SelectedValue.ToString() + "'";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataSelling.DataSource = table;
        }

        private void dataSelling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddOd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtQty.Text == "")
            {
                MessageBox.Show("Missing Information", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int Total = Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(txtQty.Text);
                DataGridViewRow addRow = new DataGridViewRow();
                addRow.CreateCells(dataOrder);
                addRow.Cells[0].Value = ++n;
                addRow.Cells[1].Value = txtName.Text;
                addRow.Cells[2].Value = txtPrice.Text;
                addRow.Cells[3].Value = txtQty.Text;
                addRow.Cells[4].Value = Total;
                dataOrder.Rows.Add(addRow);
                grandTotal += Total;
                lbAmount.Text = "GHC " + grandTotal;
            }
            
        }
    }
}
