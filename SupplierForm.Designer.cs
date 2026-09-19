namespace Pharmacy_Management_System
{
    partial class SupplierForm
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
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvSupplier = new DataGridView();
            txtSupplierName = new TextBox();
            txtContact = new TextBox();
            txtAddress = new TextBox();
            label4 = new Label();
            label5 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 80);
            label1.Name = "label1";
            label1.Size = new Size(164, 28);
            label1.TabIndex = 0;
            label1.Text = "Supplier Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 137);
            label2.Name = "label2";
            label2.Size = new Size(143, 28);
            label2.TabIndex = 1;
            label2.Text = "Contact No    :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 197);
            label3.Name = "label3";
            label3.Size = new Size(132, 28);
            label3.TabIndex = 2;
            label3.Text = "Address       :";
            label3.Click += label3_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Navy;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(62, 248);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(122, 59);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 0, 192);
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(236, 248);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 59);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Blue;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(396, 248);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 59);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(128, 128, 255);
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(564, 248);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(103, 59);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvSupplier
            // 
            dgvSupplier.BackgroundColor = Color.White;
            dgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplier.Location = new Point(52, 386);
            dgvSupplier.Name = "dgvSupplier";
            dgvSupplier.RowHeadersWidth = 51;
            dgvSupplier.Size = new Size(648, 200);
            dgvSupplier.TabIndex = 7;
            dgvSupplier.CellContentClick += dgvSupplier_CellContentClick;
            // 
            // txtSupplierName
            // 
            txtSupplierName.BackColor = SystemColors.Info;
            txtSupplierName.Location = new Point(236, 81);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(304, 27);
            txtSupplierName.TabIndex = 8;
            // 
            // txtContact
            // 
            txtContact.BackColor = SystemColors.Info;
            txtContact.Location = new Point(236, 137);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(304, 27);
            txtContact.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.Info;
            txtAddress.Location = new Point(236, 197);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(304, 27);
            txtAddress.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 102, 102);
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(207, 9);
            label4.Name = "label4";
            label4.Size = new Size(431, 41);
            label4.TabIndex = 11;
            label4.Text = "🚚 SUPPLIER MANAGEMENT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(307, 335);
            label5.Name = "label5";
            label5.Size = new Size(124, 28);
            label5.TabIndex = 13;
            label5.Text = "Supplier List";
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
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
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
            label10.Location = new Point(-13, 675);
            label10.Name = "label10";
            label10.Size = new Size(813, 23);
            label10.TabIndex = 25;
            label10.Text = "                                 © 2026 Pharmacy Management System | Developed by Group 04                           ";
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 707);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtAddress);
            Controls.Add(txtContact);
            Controls.Add(txtSupplierName);
            Controls.Add(dgvSupplier);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "SupplierForm";
            Text = "SupplierForm";
            Load += SupplierForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvSupplier;
        private TextBox txtSupplierName;
        private TextBox txtContact;
        private TextBox txtAddress;
        private Label label4;
        private Label label5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label label10;
    }
}