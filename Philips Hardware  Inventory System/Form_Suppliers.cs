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



    public partial class Form_Suppliers : Form
    {
        formops ops = new formops();
        public Form_Suppliers()
        {
            InitializeComponent();
        }

        private void Form_Suppliers_FormClosed(object sender, FormClosedEventArgs e)
        {
           // ops.ShowDashForm();
        }

        private void Form_Suppliers_Load(object sender, EventArgs e)
        {

        }
    }
}
