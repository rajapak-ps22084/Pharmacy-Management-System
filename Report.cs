
using Microsoft.Data.SqlClient;
using PharmacyManagementSystem;
using System;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            DBConnection db = new DBConnection();

            SqlConnection con = db.GetConnection();

            con.Open();

            // Total Medicines
            SqlCommand cmd1 =
                new SqlCommand(
                "SELECT COUNT(*) FROM Medicines",
                con);

            lblMedicines.Text =
                cmd1.ExecuteScalar().ToString();

            // Total Customers
            SqlCommand cmd2 =
                new SqlCommand(
                "SELECT COUNT(*) FROM Customers",
                con);

            lblCustomers.Text =
                cmd2.ExecuteScalar().ToString();

            // Total Suppliers
            SqlCommand cmd3 =
                new SqlCommand(
                "SELECT COUNT(*) FROM Suppliers",
                con);

            lblSuppliers.Text =
                cmd3.ExecuteScalar().ToString();

            // Total Sales
            SqlCommand cmd4 =
                new SqlCommand(
                "SELECT COUNT(*) FROM Sales",
                con);

            lblSales.Text =
                cmd4.ExecuteScalar().ToString();

            // Total Sales Amount
            SqlCommand cmd5 =
                new SqlCommand(
                "SELECT ISNULL(SUM(TotalAmount),0) FROM Sales",
                con);

            lblAmount.Text =
                Convert.ToDecimal(
                cmd5.ExecuteScalar())
                .ToString("N2");

            con.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadReport();
            MessageBox.Show(
        "Report Refreshed Successfully!",
        "Report",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);
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
