using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StudentDatabase
{
    class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
