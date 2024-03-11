using System;

namespace Abstract_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate an Employee object with firstName “Sample” and lastName “Student”. 
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            //Call the SayName() method on the object.
            employee.SayName();
            Console.ReadLine();

            //Use polymorphism to create an object of type IQuittable and call the Quit() method on it
            IQuittable employeeQuit = new Employee();
            employeeQuit.Quit();
        }
    }
}
