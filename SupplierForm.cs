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
    public partial class SupplierForm : Form
    {
        int supplierId = 0;
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            DBConnection db = new DBConnection();

            SqlConnection con = db.GetConnection();

            string query = "SELECT * FROM Suppliers";

            SqlDataAdapter da =
                new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvSupplier.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();

            SqlConnection con = db.GetConnection();

            string query =
            @"INSERT INTO Suppliers
    (
        SupplierName,
        ContactNo,
        Address
    )
    VALUES
    (
        @name,
        @contact,
        @address
    )";

            SqlCommand cmd =
                new SqlCommand(query, con);

            cmd.Parameters.AddWithValue(
                "@name",
                txtSupplierName.Text);

            cmd.Parameters.AddWithValue(
                "@contact",
                txtContact.Text);

            cmd.Parameters.AddWithValue(
                "@address",
                txtAddress.Text);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Supplier Added");

            LoadSuppliers();
        }

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvSupplier.Rows[e.RowIndex];

                supplierId =
                    Convert.ToInt32(
                    row.Cells["SupplierID"].Value);

                txtSupplierName.Text =
                    row.Cells["SupplierName"].Value.ToString();

                txtContact.Text =
                    row.Cells["ContactNo"].Value.ToString();

                txtAddress.Text =
                    row.Cells["Address"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (supplierId == 0)
            {
                MessageBox.Show(
                "Select a supplier first");

                return;
            }

            DBConnection db = new DBConnection();

            SqlConnection con = db.GetConnection();

            string query =
            @"UPDATE Suppliers
      SET SupplierName=@name,
          ContactNo=@contact,
          Address=@address
      WHERE SupplierID=@id";

            SqlCommand cmd =
                new SqlCommand(query, con);

            cmd.Parameters.AddWithValue(
                "@name",
                txtSupplierName.Text);

            cmd.Parameters.AddWithValue(
                "@contact",
                txtContact.Text);

            cmd.Parameters.AddWithValue(
                "@address",
                txtAddress.Text);

            cmd.Parameters.AddWithValue(
                "@id",
                supplierId);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Supplier Updated");

            LoadSuppliers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (supplierId == 0)
            {
                MessageBox.Show(
                "Select a supplier first");

                return;
            }

            DBConnection db = new DBConnection();

            SqlConnection con = db.GetConnection();

            SqlCommand cmd =
                new SqlCommand(
                "DELETE FROM Suppliers WHERE SupplierID=@id",
                con);

            cmd.Parameters.AddWithValue(
                "@id",
                supplierId);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Supplier Deleted");

            LoadSuppliers();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSupplierName.Clear();

            txtContact.Clear();

            txtAddress.Clear();

            supplierId = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();

            dashboard.Show();

            this.Hide();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
