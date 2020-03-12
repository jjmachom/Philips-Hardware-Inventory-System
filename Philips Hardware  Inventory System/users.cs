using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Philips_Hardware__Inventory_System
{
    class users
    {
        private string username;
        private string password;
        private string level;


        public users()
        {


        }

        public void setUsername(string usern)
        {

            username = usern;


        }

        public string getusername()
        {

            return username;
        }

        public void setPass(string pass)
        {

            this.password = pass;


        }

        public string getpassword()
        {

            return password;
        }


        public void setlevel(string level)
        {

            this.level = level;


        }

        public string getlevel()
        {



            return level;
        }



        public void showDash(string username, string pass,Form login)
        {

            if (username == "admin" && pass == "admin")
            {
                Dashboard dash = new Dashboard();

                dash.Show();

                login.Hide(); 

                

            }

        }




    }

}

 