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
        hardware_dbEntities1 hardware_d;
        formops ops = new formops();
        public Form_Employees()
        {
            hardware_d = new hardware_dbEntities1();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (fname_txt.Text!= null && lname_txt.Text!= null && pass_txt.Text!= null && user_stat.SelectedItem != null)
            {
                var employees = new Employee();
                employees.First_Name = fname_txt.Text;
                employees.Last_Name = lname_txt.Text;
                employees.password = pass_txt.Text;
                

                var userstats_ = user_stat.SelectedItem.ToString();
                employees.Active = userstats_;
                hardware_d.Employees.Add(employees);
                hardware_d.SaveChanges();

                employeeTableAdapter.Fill(hardware_dbDataSet1.Employee);

                MessageBox.Show("Data Successfully Submitted!");
            }
            else
            {
                MessageBox.Show("Please enter all data requested by the form!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in employeedatagrid.SelectedRows)
            {
                employeedatagrid.Rows.RemoveAt(row.Index);
                employeeTableAdapter.Fill(hardware_dbDataSet1.Employee);
            }
        }
    }
}
