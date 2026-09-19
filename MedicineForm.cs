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
    public partial class MedicineForm : Form
    {
        int medicineId = 0;
        public MedicineForm()
        {
            InitializeComponent();
        }

        private void MedicineForm_Load(object sender, EventArgs e)
        {
            LoadCategories();

            LoadSuppliers();

            LoadMedicines();
        }

        private void LoadCategories()
        {
            DBConnection db = new DBConnection();

            SqlConnection con = db.GetConnection();

            SqlDataAdapter da =
                new SqlDataAdapter(
                "SELECT CategoryID, CategoryName FROM Categories",
                con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cmbCategory.DataSource = dt;

            cmbCategory.DisplayMember = "CategoryName";

            cmbCategory.ValueMember = "CategoryID";
        }

        private void LoadSuppliers()
        {
            DBConnection db = new DBConnection();

            SqlConnection con = db.GetConnection();

            SqlDataAdapter da =
                new SqlDataAdapter(
                "SELECT SupplierID, SupplierName FROM Suppliers",
                con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cmbSupplier.DataSource = dt;

            cmbSupplier.DisplayMember = "SupplierName";

            cmbSupplier.ValueMember = "SupplierID";
        }

        private void LoadMedicines()
        {
            DBConnection db = new DBConnection();

            SqlConnection con = db.GetConnection();

            string query =
            @"SELECT *
      FROM Medicines";

            SqlDataAdapter da =
                new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvMedicine.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();

            SqlConnection con = db.GetConnection();

            string query =
            @"INSERT INTO Medicines
    (
        MedicineName,
        CategoryID,
        SupplierID,
        UnitPrice,
        Quantity,
        ExpiryDate
    )
    VALUES
    (
        @name,
        @category,
        @supplier,
        @price,
        @quantity,
        @expiry
    )";

            SqlCommand cmd =
                new SqlCommand(query, con);

            cmd.Parameters.AddWithValue(
                "@name",
                txtMedicineName.Text);

            cmd.Parameters.AddWithValue(
                "@category",
                cmbCategory.SelectedValue);

            cmd.Parameters.AddWithValue(
                "@supplier",
                cmbSupplier.SelectedValue);

            cmd.Parameters.AddWithValue(
                "@price",
                decimal.Parse(txtPrice.Text));

            cmd.Parameters.AddWithValue(
                "@quantity",
                int.Parse(txtQuantity.Text));

            cmd.Parameters.AddWithValue(
                "@expiry",
                dtpExpiry.Value);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Medicine Added");

            LoadMedicines();
        }

        private void dgvMedicine_CellClick(
object sender,
DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvMedicine.Rows[e.RowIndex];

                medicineId =
                    Convert.ToInt32(
                    row.Cells["MedicineID"].Value);

                txtMedicineName.Text =
                    row.Cells["MedicineName"].Value.ToString();

                txtPrice.Text =
                    row.Cells["UnitPrice"].Value.ToString();

                txtQuantity.Text =
                    row.Cells["Quantity"].Value.ToString();

                dtpExpiry.Value =
                    Convert.ToDateTime(
                    row.Cells["ExpiryDate"].Value);

                cmbCategory.SelectedValue =
                    row.Cells["CategoryID"].Value;

                cmbSupplier.SelectedValue =
                    row.Cells["SupplierID"].Value;


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query =
@"UPDATE Medicines
      SET MedicineName=@name,
          CategoryID=@category,
          SupplierID=@supplier,
          UnitPrice=@price,
          Quantity=@quantity,
          ExpiryDate=@expiry
      WHERE MedicineID=@id";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();

            SqlConnection con = db.GetConnection();

            SqlCommand cmd =
                new SqlCommand(
                "DELETE FROM Medicines WHERE MedicineID=@id",
                con);

            cmd.Parameters.AddWithValue(
                "@id",
                medicineId);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Deleted");

            LoadMedicines();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMedicineName.Clear();

            medicineId = 0;
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
    }
}
