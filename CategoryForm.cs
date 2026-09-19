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
    public partial class CategoryForm : Form
    {
        int categoryId = 0;
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadCategories()
        {
            DBConnection db = new DBConnection();

            SqlConnection con = db.GetConnection();

            SqlDataAdapter da =
                new SqlDataAdapter(
                "SELECT * FROM Categories",
                con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvCategory.DataSource = dt;
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();

            SqlConnection con = db.GetConnection();

            string query =
            "INSERT INTO Categories(CategoryName) VALUES(@name)";

            SqlCommand cmd =
            new SqlCommand(query, con);

            cmd.Parameters.AddWithValue(
                "@name",
                txtCategoryName.Text);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Category Added");

            LoadCategories();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                dgvCategory.Rows[e.RowIndex];

                categoryId =
                Convert.ToInt32(
                row.Cells["CategoryID"].Value);

                txtCategoryName.Text =
                row.Cells["CategoryName"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();

            SqlConnection con =
            db.GetConnection();

            string query =
            @"UPDATE Categories
      SET CategoryName=@name
      WHERE CategoryID=@id";

            SqlCommand cmd =
            new SqlCommand(query, con);

            cmd.Parameters.AddWithValue(
                "@name",
                txtCategoryName.Text);

            cmd.Parameters.AddWithValue(
                "@id",
                categoryId);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Updated");

            LoadCategories();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DBConnection db =
   new DBConnection();

            SqlConnection con =
            db.GetConnection();

            string query =
            "DELETE FROM Categories WHERE CategoryID=@id";

            SqlCommand cmd =
            new SqlCommand(query, con);

            cmd.Parameters.AddWithValue(
                "@id",
                categoryId);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Deleted");

            LoadCategories();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCategoryName.Clear();

            categoryId = 0;
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
    }
}
