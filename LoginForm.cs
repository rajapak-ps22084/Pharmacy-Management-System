using Microsoft.Data.SqlClient;
using PharmacyManagementSystem;

namespace Pharmacy_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private TextBox txtUsername;
        private Button btnSingUp;
        private Button Exit;
        private PictureBox pictureBox1;
        private Label label10;
        private TextBox txtPassword;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnSingUp = new Button();
            Exit = new Button();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Navy;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(187, 27);
            label1.Name = "label1";
            label1.Size = new Size(537, 41);
            label1.TabIndex = 0;
            label1.Text = "PHARMACY MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(83, 171);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(83, 262);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.IndianRed;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(83, 394);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(142, 51);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Info;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(279, 168);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(301, 34);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Info;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(279, 262);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(301, 34);
            txtPassword.TabIndex = 6;
            // 
            // btnSingUp
            // 
            btnSingUp.BackColor = SystemColors.HotTrack;
            btnSingUp.FlatStyle = FlatStyle.Flat;
            btnSingUp.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSingUp.ForeColor = Color.White;
            btnSingUp.Location = new Point(333, 394);
            btnSingUp.Name = "btnSingUp";
            btnSingUp.Size = new Size(135, 51);
            btnSingUp.TabIndex = 7;
            btnSingUp.Text = "Sign Up";
            btnSingUp.UseVisualStyleBackColor = false;
            btnSingUp.Click += btnSingUp_Click;
            // 
            // Exit
            // 
            Exit.BackColor = Color.Red;
            Exit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.ForeColor = Color.White;
            Exit.Location = new Point(575, 381);
            Exit.Name = "Exit";
            Exit.Size = new Size(149, 64);
            Exit.TabIndex = 8;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(59, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Lime;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(1, 471);
            label10.Name = "label10";
            label10.Size = new Size(828, 23);
            label10.TabIndex = 25;
            label10.Text = "                                    © 2026 Pharmacy Management System | Developed by Group 04                           ";
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(192, 255, 255);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(826, 512);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(Exit);
            Controls.Add(btnSingUp);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();

            SqlConnection con = db.GetConnection();

            string query =
                "SELECT * FROM Users WHERE Username=@user AND Password=@pass";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@user", txtUsername.Text);
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Login Successful");
                DashboardForm dashboard = new DashboardForm();

                dashboard.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }

            con.Close();
        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();

            register.Show();

            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}

