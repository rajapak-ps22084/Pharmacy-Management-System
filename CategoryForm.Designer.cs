namespace Pharmacy_Management_System
{
    partial class CategoryForm
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
            txtCategoryName = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvCategory = new DataGridView();
            label7 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 114);
            label1.Name = "label1";
            label1.Size = new Size(190, 31);
            label1.TabIndex = 0;
            label1.Text = "Category Name :";
            // 
            // txtCategoryName
            // 
            txtCategoryName.BackColor = SystemColors.Info;
            txtCategoryName.Location = new Point(295, 114);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(300, 27);
            txtCategoryName.TabIndex = 1;
            txtCategoryName.TextChanged += textBox1_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Navy;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(77, 206);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 48);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 0, 192);
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(233, 206);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 48);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Navy;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(409, 206);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 48);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Blue;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(572, 206);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(111, 48);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvCategory
            // 
            dgvCategory.BackgroundColor = Color.White;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Location = new Point(59, 306);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.Size = new Size(655, 195);
            dgvCategory.TabIndex = 6;
            dgvCategory.CellContentClick += dgvCategory_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(0, 102, 102);
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(165, -1);
            label7.Name = "label7";
            label7.Size = new Size(449, 41);
            label7.TabIndex = 18;
            label7.Text = "📂 CATEGORY MANAGEMENT";
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
            menuStrip1.TabIndex = 19;
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
            label10.Location = new Point(0, 576);
            label10.Name = "label10";
            label10.Size = new Size(813, 23);
            label10.TabIndex = 25;
            label10.Text = "                                 © 2026 Pharmacy Management System | Developed by Group 04                           ";
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 608);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(dgvCategory);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtCategoryName);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CategoryForm";
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCategoryName;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvCategory;
        private Label label7;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label label10;
    }
}