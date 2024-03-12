using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAssignment
{
    class Employee
    {
        //Create an Employee class with Id, FirstName and LastName properties. 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Build constructor
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        //overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property
        public static bool operator ==(Employee employeeId1, Employee employeeId2)
        {
            //check if theyre the same
            if (ReferenceEquals(employeeId1, employeeId2))
            {
                return true;
            }
            //check if null
            else if (employeeId1 is null || employeeId2 is null)
            {
                return false;
            }
            //compare and return if equal
            return employeeId1.Id == employeeId2.Id;
        }

        //verload the “!=” operator so it checks if two Employee objects are not equal by comparing their Id property
        public static bool operator !=(Employee employeeId1, Employee employeeId2)
        {
            //return if they don't equal
            return !(employeeId1 == employeeId2);
        }
    }
}
