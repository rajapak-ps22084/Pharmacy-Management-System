namespace Pharmacy_Management_System
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnBack = new Button();
            btnRegister = new Button();
            txtFullName = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            cmbRole = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(286, 81);
            label1.Name = "label1";
            label1.Size = new Size(253, 31);
            label1.TabIndex = 0;
            label1.Text = "USER REGISTRATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 159);
            label2.Name = "label2";
            label2.Size = new Size(109, 28);
            label2.TabIndex = 1;
            label2.Text = "Full Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 216);
            label3.Name = "label3";
            label3.Size = new Size(109, 28);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(57, 277);
            label4.Name = "label4";
            label4.Size = new Size(102, 28);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(57, 335);
            label5.Name = "label5";
            label5.Size = new Size(181, 28);
            label5.TabIndex = 4;
            label5.Text = "Confirm Password:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(57, 394);
            label6.Name = "label6";
            label6.Size = new Size(56, 28);
            label6.TabIndex = 5;
            label6.Text = "Role:";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.HotTrack;
            btnBack.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(434, 461);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(160, 55);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(0, 153, 153);
            btnRegister.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(136, 461);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(160, 55);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = SystemColors.Info;
            txtFullName.Location = new Point(345, 159);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(249, 27);
            txtFullName.TabIndex = 8;
            txtFullName.TextChanged += textBox1_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Info;
            txtUsername.Location = new Point(345, 216);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(249, 27);
            txtUsername.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Info;
            txtPassword.Location = new Point(345, 277);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(249, 27);
            txtPassword.TabIndex = 10;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = SystemColors.Info;
            txtConfirmPassword.Location = new Point(345, 335);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(249, 27);
            txtConfirmPassword.TabIndex = 11;
            // 
            // cmbRole
            // 
            cmbRole.BackColor = SystemColors.Info;
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(345, 394);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(249, 28);
            cmbRole.TabIndex = 12;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(0, 102, 102);
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(156, 9);
            label7.Name = "label7";
            label7.Size = new Size(537, 41);
            label7.TabIndex = 13;
            label7.Text = "PHARMACY MANAGEMENT SYSTEM";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 545);
            Controls.Add(label7);
            Controls.Add(cmbRole);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtFullName);
            Controls.Add(btnRegister);
            Controls.Add(btnBack);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnBack;
        private Button btnRegister;
        private TextBox txtFullName;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private ComboBox cmbRole;
        private Label label7;
    }
}