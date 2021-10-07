using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Data.Entity;

namespace StoragePC
{
   public class Teacher
    {
        public int Id { get; set; }

        private string login, pass;

        public string Login 
        {
             get { return login; }
             set { login = value; }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public Teacher() { }

        public Teacher( string login,string pass)
        {
            this.login = login;
            this.pass = pass;
        }

    }
}
