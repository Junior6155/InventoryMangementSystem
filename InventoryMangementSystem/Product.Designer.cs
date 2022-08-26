﻿namespace InventoryMangementSystem
{
    partial class Product
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQty = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbcategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.btnSeller = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnSelling = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.txtBB);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.cmbSearch);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtQty);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.cmbcategory);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(146, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 516);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtBB
            // 
            this.txtBB.BorderColor = System.Drawing.Color.Red;
            this.txtBB.BorderRadius = 18;
            this.txtBB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBB.DefaultText = "";
            this.txtBB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBB.ForeColor = System.Drawing.Color.Red;
            this.txtBB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBB.Location = new System.Drawing.Point(93, 321);
            this.txtBB.Name = "txtBB";
            this.txtBB.PasswordChar = '\0';
            this.txtBB.PlaceholderText = "";
            this.txtBB.SelectedText = "";
            this.txtBB.Size = new System.Drawing.Size(150, 30);
            this.txtBB.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Best Before";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(317, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(395, 368);
            this.dataGridView1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(200, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 35);
            this.label6.TabIndex = 20;
            this.label6.Text = "MANAGE PRODUCTS";
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Sitka Display", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(580, 62);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(66, 32);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(420, 62);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(154, 29);
            this.cmbSearch.TabIndex = 18;
            this.cmbSearch.Text = "Select Category";
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(116, 434);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 38);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(214, 434);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 38);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(18, 434);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 38);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
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
            this.txtName.Location = new System.Drawing.Point(93, 180);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(150, 30);
            this.txtName.TabIndex = 14;
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
            this.txtPrice.Location = new System.Drawing.Point(93, 229);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
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
            this.txtQty.Location = new System.Drawing.Point(93, 274);
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.PlaceholderText = "";
            this.txtQty.SelectedText = "";
            this.txtQty.Size = new System.Drawing.Size(150, 30);
            this.txtQty.TabIndex = 12;
            // 
            // txtID
            // 
            this.txtID.BorderColor = System.Drawing.Color.Red;
            this.txtID.BorderRadius = 18;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID.ForeColor = System.Drawing.Color.Red;
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Location = new System.Drawing.Point(93, 135);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderText = "";
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(150, 30);
            this.txtID.TabIndex = 11;
            // 
            // cmbcategory
            // 
            this.cmbcategory.FormattingEnabled = true;
            this.cmbcategory.Location = new System.Drawing.Point(93, 367);
            this.cmbcategory.Name = "cmbcategory";
            this.cmbcategory.Size = new System.Drawing.Size(145, 29);
            this.cmbcategory.TabIndex = 10;
            this.cmbcategory.Text = "Select Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.ForeColor = System.Drawing.Color.Red;
            this.lbExit.Location = new System.Drawing.Point(823, 1);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(35, 33);
            this.lbExit.TabIndex = 10;
            this.lbExit.Text = "X";
            // 
            // btnSeller
            // 
            this.btnSeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeller.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeller.Location = new System.Drawing.Point(12, 91);
            this.btnSeller.Name = "btnSeller";
            this.btnSeller.Size = new System.Drawing.Size(75, 43);
            this.btnSeller.TabIndex = 16;
            this.btnSeller.Text = "Seller";
            this.btnSeller.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(12, 444);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 43);
            this.button6.TabIndex = 17;
            this.button6.Text = "Logout";
            this.button6.UseVisualStyleBackColor = true;
          
            // 
            // btnSelling
            // 
            this.btnSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelling.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelling.Location = new System.Drawing.Point(12, 251);
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Size = new System.Drawing.Size(85, 43);
            this.btnSelling.TabIndex = 18;
            this.btnSelling.Text = "Selling";
            this.btnSelling.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.Location = new System.Drawing.Point(12, 172);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(95, 43);
            this.btnCategory.TabIndex = 19;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 565);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnSelling);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnSeller);
            this.Controls.Add(this.lbExit);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Sitka Display", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbExit;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtQty;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private System.Windows.Forms.ComboBox cmbcategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSeller;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnSelling;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox txtBB;
        private System.Windows.Forms.Label label7;
    }
}