using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Assignment
{
    //Create another class called Employee and have it inherit from the Person class.
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        //Implement the SayName() method inside of Employee class
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        public void Quit()
        {
            throw new NotImplementedException();
        }
    }
}
