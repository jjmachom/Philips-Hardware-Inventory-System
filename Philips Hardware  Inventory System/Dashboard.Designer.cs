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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_customer
            // 
            this.btn_customer.Location = new System.Drawing.Point(24, 270);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(146, 87);
            this.btn_customer.TabIndex = 0;
            this.btn_customer.Text = "Customer";
            this.btn_customer.UseVisualStyleBackColor = true;
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(486, 270);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(146, 87);
            this.btn_report.TabIndex = 1;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_pos
            // 
            this.btn_pos.Location = new System.Drawing.Point(248, 270);
            this.btn_pos.Name = "btn_pos";
            this.btn_pos.Size = new System.Drawing.Size(146, 87);
            this.btn_pos.TabIndex = 2;
            this.btn_pos.Text = "Point Of Sale";
            this.btn_pos.UseVisualStyleBackColor = true;
            this.btn_pos.Click += new System.EventHandler(this.btn_pos_Click);
            // 
            // btn_inventory
            // 
            this.btn_inventory.Location = new System.Drawing.Point(24, 63);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Size = new System.Drawing.Size(146, 87);
            this.btn_inventory.TabIndex = 3;
            this.btn_inventory.Text = "Inventory";
            this.btn_inventory.UseVisualStyleBackColor = true;
            this.btn_inventory.Click += new System.EventHandler(this.btn_inventory_Click);
            // 
            // btn_employee
            // 
            this.btn_employee.Location = new System.Drawing.Point(248, 63);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(146, 87);
            this.btn_employee.TabIndex = 4;
            this.btn_employee.Text = "Employee";
            this.btn_employee.UseVisualStyleBackColor = true;
            this.btn_employee.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_supplier
            // 
            this.btn_supplier.Location = new System.Drawing.Point(486, 63);
            this.btn_supplier.Name = "btn_supplier";
            this.btn_supplier.Size = new System.Drawing.Size(146, 87);
            this.btn_supplier.TabIndex = 5;
            this.btn_supplier.Text = "Supplier";
            this.btn_supplier.UseVisualStyleBackColor = true;
            this.btn_supplier.Click += new System.EventHandler(this.btn_supplier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_supplier);
            this.Controls.Add(this.btn_employee);
            this.Controls.Add(this.btn_inventory);
            this.Controls.Add(this.btn_pos);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_customer);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
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
        private System.Windows.Forms.Label label1;
    }
}