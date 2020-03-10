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
    public partial class Form_POS : Form
    {

        formops ops = new formops();
        public Form_POS()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void Form_POS_Load(object sender, EventArgs e)
        {

        }

        private void Form_POS_FormClosed(object sender, FormClosedEventArgs e)
        {
            ops.ShowDashForm();
        }
    }
}
