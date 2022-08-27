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
    public partial class Selling : Form
    {
        DBConnect dBCon = new DBConnect();
        public Selling()
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
            dataSelling.DataSource = table;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            getTable(); 
            getCategory();
        }

        private void dataSelling_Click(object sender, EventArgs e)
        {
            txtName.Text = dataSelling.SelectedRows[0].Cells[0].Value.ToString();
            txtPrice.Text = dataSelling.SelectedRows[0].Cells[0].Value.ToString();  
        }

        int grandTotal = 0, n = 0;
        private void btnAddOd_Click(object sender, EventArgs e)
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
        }
    }
}
