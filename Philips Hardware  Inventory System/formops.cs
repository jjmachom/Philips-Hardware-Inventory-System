using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Philips_Hardware__Inventory_System
{
    class formops
    {

        public formops()
        {



        }



        public void customerForm(Form randform)
        {

            Form_Customers cus = new Form_Customers();

            cus.Show();

            randform.Hide();
        }


        public void inventoryForm(Form randform)
        {

            Form_inventory inven = new Form_inventory();

            inven.Show();

            randform.Hide();
        }

        public void employeeForm(Form randform)
        {

            Form_Employees em = new Form_Employees();

            em.Show();

            randform.Hide();
        }


        public void posForm(Form randform)
        {

            Form_POS pos = new Form_POS();

            pos.Show();

            randform.Hide();
        }

        public void SupplierForm(Form randform)
        {

            Form_Suppliers supp = new Form_Suppliers();

            supp.Show();

            randform.Hide();
        }
        public void ReportsForm(Form randform)
        {

            Form_Reports repp = new Form_Reports();

            repp.Show();

            randform.Hide();
        }
        public void ShowDashForm()
        {

            Dashboard das = new Dashboard();

            das.Show();

            
        }
    }
}
