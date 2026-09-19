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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Cashier");
            cmbRole.Items.Add("Pharmacist");

            cmbRole.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "" ||
       txtUsername.Text == "" ||
       txtPassword.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            DBConnection db = new DBConnection();

            SqlConnection con = db.GetConnection();

            try
            {
                con.Open();

                string checkQuery =
                "SELECT COUNT(*) FROM Users WHERE Username=@user";

                SqlCommand checkCmd =
                new SqlCommand(checkQuery, con);

                checkCmd.Parameters.AddWithValue(
                    "@user",
                    txtUsername.Text);

                int count =
                (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Username already exists");
                    return;
                }

                string query =
                @"INSERT INTO Users
        (
            Username,
            Password,
            FullName,
            Role
        )
        VALUES
        (
            @user,
            @pass,
            @full,
            @role
        )";

                SqlCommand cmd =
                new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@user",
                    txtUsername.Text);

                cmd.Parameters.AddWithValue(
                    "@pass",
                    txtPassword.Text);

                cmd.Parameters.AddWithValue(
                    "@full",
                    txtFullName.Text);

                cmd.Parameters.AddWithValue(
                    "@role",
                    cmbRole.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Registration Successful");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();

            login.Show();

            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
