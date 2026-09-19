using Microsoft.Data.SqlClient;
using PharmacyManagementSystem;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Customer : Form
    {
        int customerId = 0;
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }
        private void LoadCustomers()
        {
            DBConnection db = new DBConnection();

            SqlConnection con = db.GetConnection();

            SqlDataAdapter da =
                new SqlDataAdapter(
                "SELECT * FROM Customers",
                con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvCustomer.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection db = new DBConnection();

                SqlConnection con = db.GetConnection();

                string query =
                @"INSERT INTO Customers
            (
                CustomerName,
                Phone,
                Address
            )
            VALUES
            (
                @name,
                @phone,
                @address
            )";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@name",
                    txtCustomerName.Text);

                cmd.Parameters.AddWithValue(
                    "@phone",
                    txtPhone.Text);

                cmd.Parameters.AddWithValue(
                    "@address",
                    txtAddress.Text);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Customer Added");

                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();

            SqlConnection con = db.GetConnection();

            string query =
            @"UPDATE Customers
              SET CustomerName=@name,
                  Phone=@phone,
                  Address=@address
              WHERE CustomerID=@id";

            SqlCommand cmd =
                new SqlCommand(query, con);

            cmd.Parameters.AddWithValue(
                "@id",
                customerId);

            cmd.Parameters.AddWithValue(
                "@name",
                txtCustomerName.Text);

            cmd.Parameters.AddWithValue(
                "@phone",
                txtPhone.Text);

            cmd.Parameters.AddWithValue(
                "@address",
                txtAddress.Text);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Customer Updated");

            LoadCustomers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();

            SqlConnection con = db.GetConnection();

            SqlCommand cmd =
                new SqlCommand(
                "DELETE FROM Customers WHERE CustomerID=@id",
                con);

            cmd.Parameters.AddWithValue(
                "@id",
                customerId);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Customer Deleted");

            LoadCustomers();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();

            customerId = 0;
        }

        private void dgvCustomer_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvCustomer.Rows[e.RowIndex];

                customerId =
                    Convert.ToInt32(
                    row.Cells["CustomerID"].Value);

                txtCustomerName.Text =
                    row.Cells["CustomerName"].Value.ToString();

                txtPhone.Text =
                    row.Cells["Phone"].Value.ToString();

                txtAddress.Text =
                    row.Cells["Address"].Value.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
