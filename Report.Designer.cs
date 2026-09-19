namespace Pharmacy_Management_System
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblMedicines = new Label();
            lblCustomers = new Label();
            lblSuppliers = new Label();
            lblSales = new Label();
            lblAmount = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(0, 102, 102);
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(231, 16);
            label7.Name = "label7";
            label7.Size = new Size(555, 41);
            label7.TabIndex = 16;
            label7.Text = "📊 PHARMACY REPORT DASHBOARD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 80);
            label1.Name = "label1";
            label1.Size = new Size(158, 28);
            label1.TabIndex = 17;
            label1.Text = "Total Medicines:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(89, 155);
            label2.Name = "label2";
            label2.Size = new Size(163, 28);
            label2.TabIndex = 18;
            label2.Text = "Total Customers:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(89, 237);
            label3.Name = "label3";
            label3.Size = new Size(156, 28);
            label3.TabIndex = 19;
            label3.Text = "Total Suppliers :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(89, 318);
            label4.Name = "label4";
            label4.Size = new Size(112, 28);
            label4.TabIndex = 20;
            label4.Text = "Total Sales:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(89, 397);
            label5.Name = "label5";
            label5.Size = new Size(192, 28);
            label5.TabIndex = 21;
            label5.Text = "Total Sales Amount:";
            // 
            // lblMedicines
            // 
            lblMedicines.AutoSize = true;
            lblMedicines.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMedicines.Location = new Point(343, 88);
            lblMedicines.Name = "lblMedicines";
            lblMedicines.Size = new Size(0, 28);
            lblMedicines.TabIndex = 22;
            // 
            // lblCustomers
            // 
            lblCustomers.AutoSize = true;
            lblCustomers.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomers.Location = new Point(343, 155);
            lblCustomers.Name = "lblCustomers";
            lblCustomers.Size = new Size(0, 28);
            lblCustomers.TabIndex = 23;
            // 
            // lblSuppliers
            // 
            lblSuppliers.AutoSize = true;
            lblSuppliers.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSuppliers.Location = new Point(343, 237);
            lblSuppliers.Name = "lblSuppliers";
            lblSuppliers.Size = new Size(0, 28);
            lblSuppliers.TabIndex = 24;
            // 
            // lblSales
            // 
            lblSales.AutoSize = true;
            lblSales.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSales.Location = new Point(343, 318);
            lblSales.Name = "lblSales";
            lblSales.Size = new Size(0, 28);
            lblSales.TabIndex = 25;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmount.Location = new Point(343, 397);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(0, 28);
            lblAmount.TabIndex = 26;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(278, 448);
            button1.Name = "button1";
            button1.Size = new Size(147, 48);
            button1.TabIndex = 27;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnRefresh_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(116, 11);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Lime;
            menuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(830, 31);
            menuStrip1.TabIndex = 30;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(52, 27);
            fileToolStripMenuItem.Text = "File";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(224, 28);
            dashboardToolStripMenuItem.Text = "Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 28);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Lime;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(0, 516);
            label10.Name = "label10";
            label10.Size = new Size(838, 23);
            label10.TabIndex = 31;
            label10.Text = "                                 © 2026 Pharmacy Management System | Developed by Group 04                                ";
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(830, 561);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(lblAmount);
            Controls.Add(lblSales);
            Controls.Add(lblSuppliers);
            Controls.Add(lblCustomers);
            Controls.Add(lblMedicines);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Report";
            Text = "Report";
            Load += Report_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblMedicines;
        private Label lblCustomers;
        private Label lblSuppliers;
        private Label lblSales;
        private Label lblAmount;
        private Button button1;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label label10;
    }
}