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
    public partial class Login : Form
    {
        users u1;
        public Login()
        {
            u1 = new users();
            InitializeComponent();
        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            

            u1.showDash(username.Text, pass.Text,this);
            u1.setUsername(username.Text);

            
        }

        
    }














}
