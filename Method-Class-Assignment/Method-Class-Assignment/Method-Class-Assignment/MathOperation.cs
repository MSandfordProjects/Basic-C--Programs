using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    class MathOperation
    {
        //Create a class. In that class, create a void method that takes two integers as parameters.
        public void MathMethod(int number1, int number2)
        {
            //Have the method do a math operation on the first integer  
            int OperationNum1 = number1 * 8;

            //and display the second integer to the screen.
            Console.WriteLine("The Second Number is " + number2 + ". Press Enter");
            Console.ReadLine();

            //display the math operation on the screen.
            Console.WriteLine("The First number" + number1 + " multiplied by 8 is " + OperationNum1);
            Console.ReadLine();
        }
    }
}
