using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Assignment
{
    public abstract class Person
    {
        //Create an abstract class called Person with two properties: string firstName and string lastName.
        public string firstName { get; set; }
        public string lastName { get; set; }
        //Give it the method SayName().
        public abstract void SayName();
    }

}
