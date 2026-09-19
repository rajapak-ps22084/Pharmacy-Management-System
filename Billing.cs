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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadMedicines();
            dgvSale.Columns.Clear();

            dgvSale.Columns.Add("MedicineID", "Medicine ID");
            dgvSale.Columns.Add("MedicineName", "Medicine Name");
            dgvSale.Columns.Add("Price", "Price");
            dgvSale.Columns.Add("Quantity", "Quantity");
            dgvSale.Columns.Add("Amount", "Amount");

        }

        private void LoadCustomers()
        {
            DBConnection db = new DBConnection();

            SqlConnection con = db.GetConnection();

            SqlDataAdapter da =
                new SqlDataAdapter(
                "SELECT CustomerID, CustomerName FROM Customers",
                con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cmbCustomer.DataSource = dt;

            cmbCustomer.DisplayMember = "CustomerName";

            cmbCustomer.ValueMember = "CustomerID";
        }

        private void LoadMedicines()
        {
            DBConnection db = new DBConnection();

            SqlConnection con = db.GetConnection();

            SqlDataAdapter da =
                new SqlDataAdapter(
                "SELECT MedicineID, MedicineName FROM Medicines",
                con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cmbMedicine.DataSource = dt;

            cmbMedicine.DisplayMember = "MedicineName";

            cmbMedicine.ValueMember = "MedicineID";
        }



        private void cmbMedicine_SelectedIndexChanged(
object sender,
EventArgs e)
        {
            if (cmbMedicine.SelectedValue == null)
                return;

            DBConnection db = new DBConnection();

            SqlConnection con = db.GetConnection();

            string query =
            "SELECT UnitPrice FROM Medicines WHERE MedicineID=@id";

            SqlCommand cmd =
                new SqlCommand(query, con);

            if (cmbMedicine.SelectedValue == null ||
        cmbMedicine.SelectedValue is DataRowView)
            {
                return;
            }

            cmd.Parameters.AddWithValue(
                "@id",
                Convert.ToInt32(cmbMedicine.SelectedValue));

            con.Open();

            object result =
                cmd.ExecuteScalar();

            if (result != null)
            {
                txtPrice.Text =
                    result.ToString();
            }

            con.Close();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtPrice.Text != "" && txtQuantity.Text != "")
            {
                decimal amount =
                    decimal.Parse(txtPrice.Text) *
                    int.Parse(txtQuantity.Text);


            }
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            decimal price = decimal.Parse(txtPrice.Text);
            int qty = int.Parse(txtQuantity.Text);
            decimal amount = price * qty;

            dgvSale.Rows.Add(
                cmbMedicine.SelectedValue,
                cmbMedicine.Text,
                price,
                qty,
                amount);

            decimal total = 0;

            foreach (DataGridViewRow row in dgvSale.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells[4].Value);
                }
            }

            txtGrandTotal.Text = total.ToString();
        }

        private void btnSaveSale_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            SqlConnection con = db.GetConnection();

            string query =
            @"INSERT INTO Sales
      (
          CustomerID,
          UserID,
          SaleDate,
          TotalAmount
      )
      VALUES
      (
          @customer,
          @user,
          @date,
          @total
      )";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@customer",
                cmbCustomer.SelectedValue);

            cmd.Parameters.AddWithValue("@user", 1);

            cmd.Parameters.AddWithValue("@date",
                DateTime.Now);

            cmd.Parameters.AddWithValue("@total",
                decimal.Parse(txtGrandTotal.Text));

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Sale Saved Successfully");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbCustomer.SelectedIndex = -1;
            cmbMedicine.SelectedIndex = -1;

            txtPrice.Clear();
            txtQuantity.Clear();
            txtAmount.Clear();
            txtGrandTotal.Clear();

            dgvSale.Rows.Clear();
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
