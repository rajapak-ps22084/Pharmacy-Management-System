using Microsoft.Data.SqlClient;
using PharmacyManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            LoadStock();
            LoadTotalMedicines();
        }
        private void LoadStock()
        {
            DBConnection db = new DBConnection();

            SqlConnection con = db.GetConnection();

            SqlDataAdapter da =
                new SqlDataAdapter(
                "SELECT MedicineID, MedicineName, Quantity, ExpiryDate FROM Medicines",
                con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvStock.DataSource = dt;
            lblTotalMedicines.Text =
    "Total Medicines: " + dt.Rows.Count;

        }

        private void btnLowStock_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();

            SqlConnection con = db.GetConnection();

            SqlDataAdapter da =
                new SqlDataAdapter(
                "SELECT * FROM Medicines WHERE Quantity < 10",
                con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvStock.DataSource = dt;
            lblTotalMedicines.Text =
    "Low Stock Medicines: " + dt.Rows.Count;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();

            SqlConnection con = db.GetConnection();

            SqlDataAdapter da =
                new SqlDataAdapter(
                "SELECT MedicineID, MedicineName, Quantity, ExpiryDate FROM Medicines WHERE MedicineName LIKE @name",
                con);

            da.SelectCommand.Parameters.AddWithValue(
                "@name",
                "%" + txtSearch.Text + "%");

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvStock.DataSource = dt;
            lblTotalMedicines.Text =
    "Found Medicines: " + dt.Rows.Count;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStock();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void LoadTotalMedicines()
        {
            DBConnection db = new DBConnection();

            SqlConnection con = db.GetConnection();

            SqlCommand cmd =
                new SqlCommand(
                "SELECT COUNT(*) FROM Medicines",
                con);

            con.Open();

            int total =
                Convert.ToInt32(
                cmd.ExecuteScalar());

            con.Close();

            lblTotalMedicines.Text =
                "Total Medicines: " + total;
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label7 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            label2 = new Label();
            dgvStock = new DataGridView();
            btnRefresh = new Button();
            btnLowStock = new Button();
            btnExport = new Button();
            lblTotalMedicines = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            label10 = new Label();
            ((ISupportInitialize)dgvStock).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 94);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 0;
            label1.Text = "Search Medicine:";
            label1.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(0, 102, 102);
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(237, 9);
            label7.Name = "label7";
            label7.Size = new Size(390, 41);
            label7.TabIndex = 15;
            label7.Text = "📦 STOCK MANAGEMENT";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Info;
            txtSearch.Location = new Point(271, 94);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(315, 27);
            txtSearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Red;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(640, 83);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(164, 54);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 192);
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(328, 176);
            label2.Name = "label2";
            label2.Size = new Size(135, 28);
            label2.TabIndex = 18;
            label2.Text = "Current Stock";
            // 
            // dgvStock
            // 
            dgvStock.BackgroundColor = Color.White;
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(61, 251);
            dgvStock.Name = "dgvStock";
            dgvStock.RowHeadersWidth = 51;
            dgvStock.Size = new Size(743, 183);
            dgvStock.TabIndex = 19;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Blue;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(90, 511);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(109, 43);
            btnRefresh.TabIndex = 20;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnLowStock
            // 
            btnLowStock.BackColor = Color.FromArgb(0, 0, 192);
            btnLowStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLowStock.ForeColor = Color.White;
            btnLowStock.Location = new Point(305, 511);
            btnLowStock.Name = "btnLowStock";
            btnLowStock.Size = new Size(109, 43);
            btnLowStock.TabIndex = 21;
            btnLowStock.Text = "Low Stock";
            btnLowStock.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.Navy;
            btnExport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(545, 511);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(109, 43);
            btnExport.TabIndex = 22;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // lblTotalMedicines
            // 
            lblTotalMedicines.AutoSize = true;
            lblTotalMedicines.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalMedicines.Location = new Point(296, 465);
            lblTotalMedicines.Name = "lblTotalMedicines";
            lblTotalMedicines.Size = new Size(0, 28);
            lblTotalMedicines.TabIndex = 24;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Lime;
            menuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(814, 31);
            menuStrip1.TabIndex = 25;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(52, 27);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(224, 28);
            dashboardToolStripMenuItem.Text = "Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 28);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Lime;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(0, 632);
            label10.Name = "label10";
            label10.Size = new Size(813, 23);
            label10.TabIndex = 26;
            label10.Text = "                                 © 2026 Pharmacy Management System | Developed by Group 04                           ";
            // 
            // Stock
            // 
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(814, 664);
            Controls.Add(label10);
            Controls.Add(lblTotalMedicines);
            Controls.Add(btnExport);
            Controls.Add(btnLowStock);
            Controls.Add(btnRefresh);
            Controls.Add(dgvStock);
            Controls.Add(label2);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Stock";
            ((ISupportInitialize)dgvStock).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Label label1;
        private Label label7;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label label2;
        private DataGridView dgvStock;
        private Button btnRefresh;
        private Button btnLowStock;
        private Button btnExport;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label label10;
        private Label lblTotalMedicines;

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();

            dashboard.Show();

            this.Hide();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
