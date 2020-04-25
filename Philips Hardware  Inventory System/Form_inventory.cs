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
    public partial class Form_inventory : Form
    {
        public Form_inventory()
        {
            InitializeComponent();
        }

        private void Form_inventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            formops ops = new formops();

           // ops.ShowDashForm();

        }

        private void Form_inventory_Load(object sender, EventArgs e)
        {

        }
    }
}
