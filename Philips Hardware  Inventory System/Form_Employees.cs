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
    public partial class Form_Employees : Form
    {

        formops ops = new formops();
        public Form_Employees()
        {
            InitializeComponent();
        }

        private void Form_Employees_FormClosed(object sender, FormClosedEventArgs e)
        {
            ops.ShowDashForm();
        }

        private void Form_Employees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hardware_dbDataSet1.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.hardware_dbDataSet1.Employee);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
