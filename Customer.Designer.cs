namespace Pharmacy_Management_System
{
    partial class Customer
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCustomerName = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvCustomer = new DataGridView();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(260, 20);
            label1.Name = "label1";
            label1.Size = new Size(458, 41);
            label1.TabIndex = 0;
            label1.Text = "👤 CUSTOMER MANAGEMENT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(80, 100);
            label2.Name = "label2";
            label2.Size = new Size(169, 28);
            label2.TabIndex = 1;
            label2.Text = "Customer Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(80, 160);
            label3.Name = "label3";
            label3.Size = new Size(160, 28);
            label3.TabIndex = 2;
            label3.Text = "Phone Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(80, 220);
            label4.Name = "label4";
            label4.Size = new Size(92, 28);
            label4.TabIndex = 3;
            label4.Text = "Address:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(260, 100);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(350, 27);
            txtCustomerName.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(260, 160);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(350, 27);
            txtPhone.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(260, 220);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(350, 27);
            txtAddress.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Navy;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(70, 300);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 45);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Green;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(230, 300);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 45);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(390, 300);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 45);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(550, 300);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 45);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvCustomer
            // 
            dgvCustomer.BackgroundColor = Color.White;
            dgvCustomer.ColumnHeadersHeight = 29;
            dgvCustomer.Location = new Point(70, 390);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.Size = new Size(650, 250);
            dgvCustomer.TabIndex = 11;
            dgvCustomer.CellClick += dgvCustomer_CellClick;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Lime;
            menuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 31);
            menuStrip1.TabIndex = 12;
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
            label10.Location = new Point(-13, 668);
            label10.Name = "label10";
            label10.Size = new Size(813, 23);
            label10.TabIndex = 25;
            label10.Text = "                                 © 2026 Pharmacy Management System | Developed by Group 04                           ";
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 700);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtCustomerName);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(dgvCustomer);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Customer";
            Text = "Customer Management";
            Load += Customer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;


        private TextBox txtCustomerName;
        private TextBox txtPhone;
        private TextBox txtAddress;


        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;


        private DataGridView dgvCustomer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label label10;
    }
}