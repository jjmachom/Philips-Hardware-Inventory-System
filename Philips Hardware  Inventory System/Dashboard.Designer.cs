namespace Philips_Hardware__Inventory_System
{
    partial class Dashboard
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
            this.btn_customer = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_pos = new System.Windows.Forms.Button();
            this.btn_inventory = new System.Windows.Forms.Button();
            this.btn_employee = new System.Windows.Forms.Button();
            this.btn_supplier = new System.Windows.Forms.Button();
            this.user_lbl = new System.Windows.Forms.Label();
            this.hardware_dbDataSet1 = new Philips_Hardware__Inventory_System.hardware_dbDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointOfSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.hardware_dbDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_customer
            // 
            this.btn_customer.Location = new System.Drawing.Point(76, 644);
            this.btn_customer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(389, 207);
            this.btn_customer.TabIndex = 0;
            this.btn_customer.Text = "Customer";
            this.btn_customer.UseVisualStyleBackColor = true;
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(1266, 644);
            this.btn_report.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(389, 207);
            this.btn_report.TabIndex = 1;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_pos
            // 
            this.btn_pos.Location = new System.Drawing.Point(680, 644);
            this.btn_pos.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_pos.Name = "btn_pos";
            this.btn_pos.Size = new System.Drawing.Size(389, 207);
            this.btn_pos.TabIndex = 2;
            this.btn_pos.Text = "Point Of Sale";
            this.btn_pos.UseVisualStyleBackColor = true;
            this.btn_pos.Click += new System.EventHandler(this.btn_pos_Click);
            // 
            // btn_inventory
            // 
            this.btn_inventory.Location = new System.Drawing.Point(656, 185);
            this.btn_inventory.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Size = new System.Drawing.Size(389, 207);
            this.btn_inventory.TabIndex = 3;
            this.btn_inventory.Text = "Inventory";
            this.btn_inventory.UseVisualStyleBackColor = true;
            this.btn_inventory.Click += new System.EventHandler(this.btn_inventory_Click);
            // 
            // btn_employee
            // 
            this.btn_employee.Location = new System.Drawing.Point(61, 185);
            this.btn_employee.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(389, 207);
            this.btn_employee.TabIndex = 4;
            this.btn_employee.Text = "Employee";
            this.btn_employee.UseVisualStyleBackColor = true;
            this.btn_employee.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_supplier
            // 
            this.btn_supplier.Location = new System.Drawing.Point(1250, 185);
            this.btn_supplier.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_supplier.Name = "btn_supplier";
            this.btn_supplier.Size = new System.Drawing.Size(389, 207);
            this.btn_supplier.TabIndex = 5;
            this.btn_supplier.Text = "Supplier";
            this.btn_supplier.UseVisualStyleBackColor = true;
            this.btn_supplier.Click += new System.EventHandler(this.btn_supplier_Click);
            // 
            // user_lbl
            // 
            this.user_lbl.AutoSize = true;
            this.user_lbl.Location = new System.Drawing.Point(1539, 52);
            this.user_lbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.user_lbl.Name = "user_lbl";
            this.user_lbl.Size = new System.Drawing.Size(145, 32);
            this.user_lbl.TabIndex = 6;
            this.user_lbl.Text = "Username";
            this.user_lbl.Click += new System.EventHandler(this.user_lbl_Click);
            // 
            // hardware_dbDataSet1
            // 
            this.hardware_dbDataSet1.DataSetName = "hardware_dbDataSet";
            this.hardware_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1875, 49);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.supplierToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.pointOfSaleToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(119, 48);
            this.toolStripMenuItem1.Text = "Menu";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.supplierToolStripMenuItem.Text = "Supplier";
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.supplierToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // pointOfSaleToolStripMenuItem
            // 
            this.pointOfSaleToolStripMenuItem.Name = "pointOfSaleToolStripMenuItem";
            this.pointOfSaleToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.pointOfSaleToolStripMenuItem.Text = "Point Of Sale";
            this.pointOfSaleToolStripMenuItem.Click += new System.EventHandler(this.pointOfSaleToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1875, 1043);
            this.Controls.Add(this.user_lbl);
            this.Controls.Add(this.btn_supplier);
            this.Controls.Add(this.btn_employee);
            this.Controls.Add(this.btn_inventory);
            this.Controls.Add(this.btn_pos);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_customer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hardware_dbDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_customer;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_pos;
        private System.Windows.Forms.Button btn_inventory;
        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.Button btn_supplier;
        private System.Windows.Forms.Label user_lbl;
        private hardware_dbDataSet hardware_dbDataSet1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointOfSaleToolStripMenuItem;
    }
}