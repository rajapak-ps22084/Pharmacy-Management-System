namespace Pharmacy_Management_System
{
    partial class Billing
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
            label2 = new Label();
            label3 = new Label();
            cmbCustomer = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAddItem = new Button();
            dgvSale = new DataGridView();
            label8 = new Label();
            txtGrandTotal = new TextBox();
            btnSaveSale = new Button();
            btnClear = new Button();
            label9 = new Label();
            cmbMedicine = new ComboBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            label7 = new Label();
            txtAmount = new TextBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSale).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 192);
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(337, 65);
            label2.Name = "label2";
            label2.Size = new Size(167, 28);
            label2.TabIndex = 1;
            label2.Text = "Customer Details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 118);
            label3.Name = "label3";
            label3.Size = new Size(151, 25);
            label3.TabIndex = 2;
            label3.Text = "Customer Name:";
            // 
            // cmbCustomer
            // 
            cmbCustomer.BackColor = SystemColors.Info;
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(231, 115);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(372, 28);
            cmbCustomer.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 192, 192);
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(337, 159);
            label4.Name = "label4";
            label4.Size = new Size(161, 28);
            label4.TabIndex = 4;
            label4.Text = "Medicine Details";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(55, 207);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 5;
            label5.Text = "Medicine:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(55, 257);
            label6.Name = "label6";
            label6.Size = new Size(98, 25);
            label6.TabIndex = 6;
            label6.Text = "Unit Price:";
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.Navy;
            btnAddItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddItem.ForeColor = Color.White;
            btnAddItem.Location = new Point(75, 348);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(119, 50);
            btnAddItem.TabIndex = 8;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // dgvSale
            // 
            dgvSale.BackgroundColor = Color.White;
            dgvSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSale.Location = new Point(75, 404);
            dgvSale.Name = "dgvSale";
            dgvSale.RowHeadersWidth = 51;
            dgvSale.Size = new Size(652, 161);
            dgvSale.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(85, 582);
            label8.Name = "label8";
            label8.Size = new Size(121, 28);
            label8.TabIndex = 10;
            label8.Text = "Grand Total:";
            // 
            // txtGrandTotal
            // 
            txtGrandTotal.BackColor = SystemColors.Info;
            txtGrandTotal.Location = new Point(341, 582);
            txtGrandTotal.Name = "txtGrandTotal";
            txtGrandTotal.Size = new Size(372, 27);
            txtGrandTotal.TabIndex = 11;
            // 
            // btnSaveSale
            // 
            btnSaveSale.BackColor = Color.Navy;
            btnSaveSale.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveSale.ForeColor = Color.White;
            btnSaveSale.Location = new Point(121, 623);
            btnSaveSale.Name = "btnSaveSale";
            btnSaveSale.Size = new Size(133, 44);
            btnSaveSale.TabIndex = 12;
            btnSaveSale.Text = "Save Sale";
            btnSaveSale.UseVisualStyleBackColor = false;
            btnSaveSale.Click += btnSaveSale_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(0, 0, 192);
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(352, 623);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(133, 44);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(430, 256);
            label9.Name = "label9";
            label9.Size = new Size(89, 25);
            label9.TabIndex = 15;
            label9.Text = "Quantity:";
            // 
            // cmbMedicine
            // 
            cmbMedicine.BackColor = SystemColors.Info;
            cmbMedicine.FormattingEnabled = true;
            cmbMedicine.Location = new Point(231, 207);
            cmbMedicine.Name = "cmbMedicine";
            cmbMedicine.Size = new Size(372, 28);
            cmbMedicine.TabIndex = 16;
            cmbMedicine.SelectedIndexChanged += cmbMedicine_SelectedIndexChanged;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.Info;
            txtPrice.Location = new Point(231, 257);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(170, 27);
            txtPrice.TabIndex = 17;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = SystemColors.Info;
            txtQuantity.Location = new Point(525, 257);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(188, 27);
            txtQuantity.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(55, 304);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 19;
            label7.Text = "Amount:";
            // 
            // txtAmount
            // 
            txtAmount.BackColor = SystemColors.Info;
            txtAmount.Location = new Point(231, 305);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(372, 27);
            txtAmount.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 102, 102);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(180, 0);
            label1.Name = "label1";
            label1.Size = new Size(482, 41);
            label1.TabIndex = 21;
            label1.Text = "\U0001f9fe PHARMACY BILLING SYSTEM";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SpringGreen;
            menuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(800, 31);
            menuStrip1.TabIndex = 23;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor = Color.SeaGreen;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fileToolStripMenuItem.ForeColor = Color.Black;
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
            label10.Location = new Point(0, 688);
            label10.Name = "label10";
            label10.Size = new Size(813, 23);
            label10.TabIndex = 24;
            label10.Text = "                                 © 2026 Pharmacy Management System | Developed by Group 04                           ";
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 720);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(txtAmount);
            Controls.Add(label7);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(cmbMedicine);
            Controls.Add(label9);
            Controls.Add(btnClear);
            Controls.Add(btnSaveSale);
            Controls.Add(txtGrandTotal);
            Controls.Add(label8);
            Controls.Add(dgvSale);
            Controls.Add(btnAddItem);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cmbCustomer);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Billing";
            Text = "Billing";
            Load += Billing_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSale).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private ComboBox cmbCustomer;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAddItem;
        private DataGridView dgvSale;
        private Label label8;
        private TextBox txtGrandTotal;
        private Button btnSaveSale;
        private Button btnClear;
        private Label label9;
        private ComboBox cmbMedicine;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Label label7;
        private TextBox txtAmount;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label label10;
    }
}