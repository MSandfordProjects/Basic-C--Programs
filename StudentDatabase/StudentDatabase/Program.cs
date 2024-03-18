using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            var addStudent = new Student()
            {
                Id = 3351,
                FirstName = "Jesse",
                LastName = "Black"
            };

            using (var dbContext = new StudentDbContext())
            {
                dbContext.Students.Add(addStudent);
                dbContext.SaveChanges();
            }

            Console.WriteLine("Added Student");
            Console.ReadLine();
        }
    }
}
