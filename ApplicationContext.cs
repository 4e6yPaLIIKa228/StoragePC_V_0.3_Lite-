using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StoragePC
{
    class ApplicationContext : DbContext
    {

        public ApplicationContext() : base ("DefaultConnection") 
        {

        }
        public DbSet<Device> Devices { get; set; }
        //public DbSet<Teacher> Teachers { get; set; }
    }
}
