using System;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }


        private void medicinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicineForm medicine = new MedicineForm();
            medicine.Show();
        }



        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
        }



        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierForm supplier = new SupplierForm();
            supplier.Show();
        }



        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
        }


        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.Show();
        }



        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Billing billing = new Billing();
            billing.Show();
        }



        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }



        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Do you want to logout?",
        "Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 login = new Form1();

                login.Show();

                this.Hide();
            }
        }


        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
