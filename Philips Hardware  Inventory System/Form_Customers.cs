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
        private readonly hardware_dbEntities1 hardware_d = new hardware_dbEntities1();

        
        
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
            //this.customerTableAdapter.Fill(this.hardware_dbDataSet.Customer);
            
        }

        private void btncus_add_Click(object sender, EventArgs e)
        {

            if ( fname.Text!= "")
            {
                var customer_data = new Customer();
                customer_data.First_Name = fname.Text;

                customer_data.Last_Name = lname.Text;
                customer_data.Telephone = tel.Text;

                hardware_d.Customers.Add(customer_data);
                hardware_d.SaveChanges();


                dataGridView1.Refresh();
            }
            else
            {

                MessageBox.Show("Customer Field cannot be empty!");
            }
        }
    }
}
