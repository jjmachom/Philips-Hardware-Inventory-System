using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Philips_Hardware__Inventory_System
{
    public partial class Dashboard : Form
    {
        users user1 = new users();

        formops ops = new formops();
        public Dashboard()
        {

            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ops.employeeForm(this);

        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            ops.inventoryForm(this);
        }

        private void btn_pos_Click(object sender, EventArgs e)
        {
            ops.posForm(this);
        }

        private void btn_supplier_Click(object sender, EventArgs e)
        {
            ops.SupplierForm(this);
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            ops.customerForm(this);
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            ops.ReportsForm(this);
        }

        private void user_lbl_Click(object sender, EventArgs e)
        {

        }

        public void setlabel(string username_)
        {

           

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            setlabel(user1.getusername());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_inventory inven = new Form_inventory();

            inven.MdiParent = this;

            inven.Show();
           

            
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Employees Employee = new Form_Employees();

            Employee.MdiParent= this;
            Employee.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Suppliers Supplier_Frm = new Form_Suppliers();
            Supplier_Frm.MdiParent = this;
            Supplier_Frm.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Customers cusform = new Form_Customers();

            cusform.MdiParent = this;

            cusform.Show();

           // ops.customerForm(this);
        }

        private void pointOfSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_POS pos = new Form_POS();
            pos.MdiParent = this;
            pos.Show();
            //ops.posForm(this);
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Reports Reports_Frm = new Form_Reports();
            Reports_Frm.MdiParent = this;
            Reports_Frm.Show();
        }

        private void detachWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ops.customerForm(this);
        }
    }
}
