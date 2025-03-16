using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnamePswd
{
    public class Login
    {


        public string DoLogin(string Uname, string Pswd)
        {


            if (Uname == null || Pswd == null)
            {
                throw new ArgumentNullException("Please provide credentials");
            }
            else
            {
                Uname = "admin;";
                Pswd = "admin";
            }
            
         return Uname;
         return Pswd;

        }

    }
}
