namespace InventoryMangementSystem
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbLogout = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQty = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAddOd = new System.Windows.Forms.Button();
            this.lbExit = new System.Windows.Forms.Label();
            this.dataOrder = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOd = new System.Windows.Forms.Button();
            this.dataList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbSeller = new System.Windows.Forms.Label();
            this.dataSelling = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrder)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSelling)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogout.ForeColor = System.Drawing.Color.Black;
            this.lbLogout.Location = new System.Drawing.Point(12, 466);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(100, 35);
            this.lbLogout.TabIndex = 39;
            this.lbLogout.Text = "Logout";
            this.lbLogout.Click += new System.EventHandler(this.lbLogout_Click);
            this.lbLogout.MouseEnter += new System.EventHandler(this.lbLogout_MouseEnter);
            this.lbLogout.MouseLeave += new System.EventHandler(this.lbLogout_MouseLeave);
            // 
            // txtPrice
            // 
            this.txtPrice.BorderColor = System.Drawing.Color.Red;
            this.txtPrice.BorderRadius = 18;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.ForeColor = System.Drawing.Color.Red;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(97, 123);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(150, 30);
            this.txtPrice.TabIndex = 13;
            // 
            // txtQty
            // 
            this.txtQty.BorderColor = System.Drawing.Color.Red;
            this.txtQty.BorderRadius = 18;
            this.txtQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.DefaultText = "";
            this.txtQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQty.ForeColor = System.Drawing.Color.Red;
            this.txtQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQty.Location = new System.Drawing.Point(97, 172);
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.PlaceholderText = "";
            this.txtQty.SelectedText = "";
            this.txtQty.Size = new System.Drawing.Size(150, 30);
            this.txtQty.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity";
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(649, 475);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(70, 38);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAddOd
            // 
            this.btnAddOd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOd.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOd.Location = new System.Drawing.Point(147, 216);
            this.btnAddOd.Name = "btnAddOd";
            this.btnAddOd.Size = new System.Drawing.Size(100, 32);
            this.btnAddOd.TabIndex = 15;
            this.btnAddOd.Text = "Add Order";
            this.btnAddOd.UseVisualStyleBackColor = true;
            this.btnAddOd.Click += new System.EventHandler(this.btnAddOd_Click);
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.ForeColor = System.Drawing.Color.Red;
            this.lbExit.Location = new System.Drawing.Point(858, -4);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(35, 33);
            this.lbExit.TabIndex = 35;
            this.lbExit.Text = "X";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            this.lbExit.MouseEnter += new System.EventHandler(this.lbExit_MouseEnter);
            this.lbExit.MouseLeave += new System.EventHandler(this.lbExit_MouseLeave);
            // 
            // dataOrder
            // 
            dataGridViewCellStyle55.BackColor = System.Drawing.Color.White;
            this.dataOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle55;
            dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Sitka Display", 11F);
            dataGridViewCellStyle56.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle56.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle56.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle56.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle56;
            this.dataOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdId,
            this.ProdName,
            this.ProdPrice,
            this.ProdQty,
            this.Total});
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle57.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Sitka Display", 11F);
            dataGridViewCellStyle57.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle57.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle57.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataOrder.DefaultCellStyle = dataGridViewCellStyle57;
            this.dataOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataOrder.Location = new System.Drawing.Point(283, 73);
            this.dataOrder.Name = "dataOrder";
            this.dataOrder.RowHeadersVisible = false;
            this.dataOrder.Size = new System.Drawing.Size(436, 140);
            this.dataOrder.TabIndex = 24;
            this.dataOrder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataOrder.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataOrder.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataOrder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataOrder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataOrder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataOrder.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 11F);
            this.dataOrder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataOrder.ThemeStyle.HeaderStyle.Height = 23;
            this.dataOrder.ThemeStyle.ReadOnly = false;
            this.dataOrder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataOrder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataOrder.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 11F);
            this.dataOrder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataOrder.ThemeStyle.RowsStyle.Height = 22;
            this.dataOrder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataOrder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ProdId
            // 
            this.ProdId.HeaderText = "ProdId";
            this.ProdId.Name = "ProdId";
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "ProdName";
            this.ProdName.Name = "ProdName";
            // 
            // ProdPrice
            // 
            this.ProdPrice.HeaderText = "ProdPrice";
            this.ProdPrice.Name = "ProdPrice";
            // 
            // ProdQty
            // 
            this.ProdQty.HeaderText = "ProdQty";
            this.ProdQty.Name = "ProdQty";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(293, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 35);
            this.label6.TabIndex = 20;
            this.label6.Text = "ORDER";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(649, 278);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 38);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.BorderColor = System.Drawing.Color.Red;
            this.txtName.BorderRadius = 18;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.ForeColor = System.Drawing.Color.Red;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(97, 74);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.ReadOnly = true;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(150, 30);
            this.txtName.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbAmount);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnOd);
            this.panel1.Controls.Add(this.dataList);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.cmbCat);
            this.panel1.Controls.Add(this.lbDate);
            this.panel1.Controls.Add(this.lbSeller);
            this.panel1.Controls.Add(this.dataSelling);
            this.panel1.Controls.Add(this.dataOrder);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnAddOd);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtQty);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(123, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 516);
            this.panel1.TabIndex = 34;
            // 
            // txtId
            // 
            this.txtId.BorderColor = System.Drawing.Color.Red;
            this.txtId.BorderRadius = 18;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.DefaultText = "";
            this.txtId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtId.ForeColor = System.Drawing.Color.Red;
            this.txtId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.Location = new System.Drawing.Point(561, 286);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PlaceholderText = "";
            this.txtId.SelectedText = "";
            this.txtId.Size = new System.Drawing.Size(82, 30);
            this.txtId.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(509, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 23);
            this.label8.TabIndex = 34;
            this.label8.Text = "BillId";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.Location = new System.Drawing.Point(530, 216);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(40, 23);
            this.lbAmount.TabIndex = 33;
            this.lbAmount.Text = "GHC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(360, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 23);
            this.label7.TabIndex = 32;
            this.label7.Text = "Amount";
            // 
            // btnOd
            // 
            this.btnOd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOd.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOd.Location = new System.Drawing.Point(284, 281);
            this.btnOd.Name = "btnOd";
            this.btnOd.Size = new System.Drawing.Size(100, 32);
            this.btnOd.TabIndex = 31;
            this.btnOd.Text = "Order List";
            this.btnOd.UseVisualStyleBackColor = true;
            // 
            // dataList
            // 
            dataGridViewCellStyle58.BackColor = System.Drawing.Color.White;
            this.dataList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle58;
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Sitka Display", 11F);
            dataGridViewCellStyle59.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle59;
            this.dataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle60.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle60.Font = new System.Drawing.Font("Sitka Display", 11F);
            dataGridViewCellStyle60.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle60.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle60.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle60.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataList.DefaultCellStyle = dataGridViewCellStyle60;
            this.dataList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataList.Location = new System.Drawing.Point(283, 322);
            this.dataList.Name = "dataList";
            this.dataList.RowHeadersVisible = false;
            this.dataList.Size = new System.Drawing.Size(436, 147);
            this.dataList.TabIndex = 30;
            this.dataList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 11F);
            this.dataList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataList.ThemeStyle.HeaderStyle.Height = 23;
            this.dataList.ThemeStyle.ReadOnly = false;
            this.dataList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 11F);
            this.dataList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataList.ThemeStyle.RowsStyle.Height = 22;
            this.dataList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(158, 281);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(87, 31);
            this.btnRefresh.TabIndex = 29;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // cmbCat
            // 
            this.cmbCat.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.Location = new System.Drawing.Point(12, 281);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(140, 31);
            this.cmbCat.TabIndex = 28;
            this.cmbCat.Text = "Select Category";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(600, 47);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(43, 23);
            this.lbDate.TabIndex = 27;
            this.lbDate.Text = "Date:";
            // 
            // lbSeller
            // 
            this.lbSeller.AutoSize = true;
            this.lbSeller.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeller.Location = new System.Drawing.Point(37, 40);
            this.lbSeller.Name = "lbSeller";
            this.lbSeller.Size = new System.Drawing.Size(87, 23);
            this.lbSeller.TabIndex = 26;
            this.lbSeller.Text = "Seller Name";
            // 
            // dataSelling
            // 
            dataGridViewCellStyle61.BackColor = System.Drawing.Color.White;
            this.dataSelling.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle61;
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Sitka Display", 11F);
            dataGridViewCellStyle62.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle62.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle62.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataSelling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle62;
            this.dataSelling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle63.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Sitka Display", 11F);
            dataGridViewCellStyle63.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle63.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle63.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataSelling.DefaultCellStyle = dataGridViewCellStyle63;
            this.dataSelling.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataSelling.Location = new System.Drawing.Point(14, 338);
            this.dataSelling.Name = "dataSelling";
            this.dataSelling.RowHeadersVisible = false;
            this.dataSelling.Size = new System.Drawing.Size(249, 161);
            this.dataSelling.TabIndex = 25;
            this.dataSelling.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataSelling.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataSelling.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataSelling.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataSelling.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataSelling.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataSelling.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataSelling.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataSelling.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataSelling.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 11F);
            this.dataSelling.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataSelling.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataSelling.ThemeStyle.HeaderStyle.Height = 23;
            this.dataSelling.ThemeStyle.ReadOnly = false;
            this.dataSelling.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataSelling.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataSelling.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 11F);
            this.dataSelling.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataSelling.ThemeStyle.RowsStyle.Height = 22;
            this.dataSelling.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataSelling.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataSelling.Click += new System.EventHandler(this.dataSelling_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 565);
            this.Controls.Add(this.lbLogout);
            this.Controls.Add(this.lbExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selling";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSelling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogout;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnAddOd;
        private System.Windows.Forms.Label lbExit;
        private Guna.UI2.WinForms.Guna2DataGridView dataOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dataSelling;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbCat;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbSeller;
        private Guna.UI2.WinForms.Guna2DataGridView dataList;
        private System.Windows.Forms.Button btnOd;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private Guna.UI2.WinForms.Guna2TextBox txtId;
        private System.Windows.Forms.Label label8;
    }
}