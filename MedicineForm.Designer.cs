namespace Pharmacy_Management_System
{
    partial class MedicineForm
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
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvMedicine = new DataGridView();
            txtMedicineName = new TextBox();
            cmbCategory = new ComboBox();
            cmbSupplier = new ComboBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            dtpExpiry = new DateTimePicker();
            label7 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMedicine).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 61);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 0;
            label1.Text = "Medicine Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(92, 111);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "Category      :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(92, 162);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 2;
            label3.Text = "Supplier      :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(92, 218);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 3;
            label4.Text = "Unit Price    :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(92, 276);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 4;
            label5.Text = "Quantity      :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(92, 331);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 5;
            label6.Text = "Expiry Date   :";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Navy;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(43, 384);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 49);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Blue;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(178, 384);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 49);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Navy;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(313, 384);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 49);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delele";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Navy;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(443, 384);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 49);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvMedicine
            // 
            dgvMedicine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicine.BackgroundColor = Color.White;
            dgvMedicine.BorderStyle = BorderStyle.None;
            dgvMedicine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicine.Location = new Point(54, 448);
            dgvMedicine.Name = "dgvMedicine";
            dgvMedicine.RowHeadersWidth = 51;
            dgvMedicine.Size = new Size(532, 188);
            dgvMedicine.TabIndex = 10;
            // 
            // txtMedicineName
            // 
            txtMedicineName.BackColor = SystemColors.Info;
            txtMedicineName.Location = new Point(290, 61);
            txtMedicineName.Name = "txtMedicineName";
            txtMedicineName.Size = new Size(266, 27);
            txtMedicineName.TabIndex = 11;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = SystemColors.Info;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(290, 111);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(266, 28);
            cmbCategory.TabIndex = 12;
            // 
            // cmbSupplier
            // 
            cmbSupplier.BackColor = SystemColors.Info;
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(290, 162);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(266, 28);
            cmbSupplier.TabIndex = 13;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.Info;
            txtPrice.Location = new Point(290, 218);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(266, 27);
            txtPrice.TabIndex = 14;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = SystemColors.Info;
            txtQuantity.Location = new Point(290, 276);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(266, 27);
            txtQuantity.TabIndex = 15;
            // 
            // dtpExpiry
            // 
            dtpExpiry.CalendarMonthBackground = SystemColors.Info;
            dtpExpiry.Location = new Point(290, 326);
            dtpExpiry.Name = "dtpExpiry";
            dtpExpiry.Size = new Size(266, 27);
            dtpExpiry.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(0, 102, 102);
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(178, -2);
            label7.Name = "label7";
            label7.Size = new Size(441, 41);
            label7.TabIndex = 17;
            label7.Text = "💊MEDICINE MANAGEMENT ";
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
            menuStrip1.TabIndex = 18;
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
            label10.Location = new Point(0, 657);
            label10.Name = "label10";
            label10.Size = new Size(813, 23);
            label10.TabIndex = 25;
            label10.Text = "                                 © 2026 Pharmacy Management System | Developed by Group 04                           ";
            // 
            // MedicineForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 680);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(dtpExpiry);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(cmbSupplier);
            Controls.Add(cmbCategory);
            Controls.Add(txtMedicineName);
            Controls.Add(dgvMedicine);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MedicineForm";
            Text = "MedicineForm";
            Load += MedicineForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedicine).EndInit();
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
        private Label label5;
        private Label label6;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvMedicine;
        private TextBox txtMedicineName;
        private ComboBox cmbCategory;
        private ComboBox cmbSupplier;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private DateTimePicker dtpExpiry;
        private Label label7;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label label10;
    }
}