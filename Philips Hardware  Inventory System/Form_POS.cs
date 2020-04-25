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
        //private readonly hardware_dbEntities1 hardware_d;
        /*public void loadcus()
        {
            //Select * from Customers
            var hardware = hardware_d.Customers.ToList();
            var member = "Last_Name";
            dp_cus.DisplayMember = member;
            dp_cus.ValueMember = "cusId";
            dp_cus.DataSource = hardware;
        }*/

        formops ops = new formops();
        public Form_POS()
        {
            InitializeComponent();
            //hardware_d = new hardware_dbEntities1();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void Form_POS_Load(object sender, EventArgs e)
        { 
            //reload Combo box data
           // loadcus();
            
            
        }

        private void Form_POS_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ops.ShowDashForm();
        }

        private void button14_Click(object sender, EventArgs e)
        {

            var condition1 = fname;

            if (condition1.Text !="")
            {
                var customer_data = new Customer();
                customer_data.First_Name = fname.Text;

                customer_data.Last_Name = lname.Text;

              //  hardware_d.Customers.Add(customer_data);
               // hardware_d.SaveChanges();

               // loadcus();

            }
            else
            {

                MessageBox.Show("Customer Field cannot be empty!");
            }
            
        }
    }
}
