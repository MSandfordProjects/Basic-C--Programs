using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate two objects of the Employee class and assign values to their properties.
            Employee employeeId1 = new Employee(1, "Bob", "Green");
            Employee employeeId2 = new Employee(2, "Lisa", "Jones");


            //compare the two Employee objects using the newly overloaded operators and display the results
            if (employeeId1 == employeeId2)
            {
                Console.WriteLine("Employees are equal based on their Id.");
            }
            else
            {
                Console.WriteLine("Employees are not equal based on their Id.");
            }
        }
    }
}
