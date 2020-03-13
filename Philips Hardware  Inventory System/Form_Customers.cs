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
    public partial class Form_Customers : Form
    {


        formops ops = new formops();
        public Form_Customers()
        {
            InitializeComponent();
        }

        private void Form_Customers_FormClosed(object sender, FormClosedEventArgs e)
        {
            ops.ShowDashForm();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hardware_dbDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.hardware_dbDataSet.Customer);
            
        }
    }
}
