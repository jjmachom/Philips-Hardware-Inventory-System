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
    }
}
