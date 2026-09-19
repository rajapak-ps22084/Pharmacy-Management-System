namespace Pharmacy_Management_System
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            managementToolStripMenuItem = new ToolStripMenuItem();
            medicinesToolStripMenuItem = new ToolStripMenuItem();
            customersToolStripMenuItem = new ToolStripMenuItem();
            supliersToolStripMenuItem = new ToolStripMenuItem();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            salesToolStripMenuItem = new ToolStripMenuItem();
            billingToolStripMenuItem = new ToolStripMenuItem();
            stocksToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            label10 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(143, 44);
            label1.Name = "label1";
            label1.Size = new Size(0, 31);
            label1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Aquamarine;
            menuStrip1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, managementToolStripMenuItem, salesToolStripMenuItem, reportsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(788, 31);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, logoutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(50, 27);
            fileToolStripMenuItem.Text = "File";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(224, 28);
            dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(224, 28);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 28);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // managementToolStripMenuItem
            // 
            managementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { medicinesToolStripMenuItem, customersToolStripMenuItem, supliersToolStripMenuItem, categoryToolStripMenuItem });
            managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            managementToolStripMenuItem.Size = new Size(127, 27);
            managementToolStripMenuItem.Text = "Management";
            // 
            // medicinesToolStripMenuItem
            // 
            medicinesToolStripMenuItem.Name = "medicinesToolStripMenuItem";
            medicinesToolStripMenuItem.Size = new Size(175, 28);
            medicinesToolStripMenuItem.Text = "Medicines";
            medicinesToolStripMenuItem.Click += medicinesToolStripMenuItem_Click;
            // 
            // customersToolStripMenuItem
            // 
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new Size(175, 28);
            customersToolStripMenuItem.Text = "Customers";
            customersToolStripMenuItem.Click += customersToolStripMenuItem_Click;
            // 
            // supliersToolStripMenuItem
            // 
            supliersToolStripMenuItem.Name = "supliersToolStripMenuItem";
            supliersToolStripMenuItem.Size = new Size(175, 28);
            supliersToolStripMenuItem.Text = "Supliers";
            supliersToolStripMenuItem.Click += suppliersToolStripMenuItem_Click;
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(175, 28);
            categoryToolStripMenuItem.Text = "Category";
            categoryToolStripMenuItem.Click += categoriesToolStripMenuItem_Click;
            // 
            // salesToolStripMenuItem
            // 
            salesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { billingToolStripMenuItem, stocksToolStripMenuItem });
            salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            salesToolStripMenuItem.Size = new Size(62, 27);
            salesToolStripMenuItem.Text = "Sales";
            // 
            // billingToolStripMenuItem
            // 
            billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            billingToolStripMenuItem.Size = new Size(143, 28);
            billingToolStripMenuItem.Text = "Billing";
            billingToolStripMenuItem.Click += billingToolStripMenuItem_Click;
            // 
            // stocksToolStripMenuItem
            // 
            stocksToolStripMenuItem.Name = "stocksToolStripMenuItem";
            stocksToolStripMenuItem.Size = new Size(143, 28);
            stocksToolStripMenuItem.Text = "Stocks";
            stocksToolStripMenuItem.Click += stockToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(83, 27);
            reportsToolStripMenuItem.Text = "Reports";
            reportsToolStripMenuItem.Click += reportsToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(90, 62);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(623, 312);
            label2.TabIndex = 16;
            label2.Text = "PHARMACY MANAGEMENT SYSTEM";
            label2.Click += label2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Lime;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(-12, 468);
            label10.Name = "label10";
            label10.Size = new Size(813, 23);
            label10.TabIndex = 25;
            label10.Text = "                                 © 2026 Pharmacy Management System | Developed by Group 04                           ";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(788, 500);
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnUsers;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem managementToolStripMenuItem;
        private ToolStripMenuItem medicinesToolStripMenuItem;
        private ToolStripMenuItem customersToolStripMenuItem;
        private ToolStripMenuItem supliersToolStripMenuItem;
        private ToolStripMenuItem salesToolStripMenuItem;
        private ToolStripMenuItem billingToolStripMenuItem;
        private ToolStripMenuItem stocksToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private Label label2;
        private Label label10;
    }
}