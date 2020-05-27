using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HangManV2.Data;
using System.Data.Entity;
using MySql.Data.EntityFramework;

namespace HangManV2.Data
{
    public class UserContext : DbContext
    {
        public UserContext()
           :base("name=hangmanEntities")
            {
            
            }
        public DbSet<User> Users { get; set; }
    }
}
