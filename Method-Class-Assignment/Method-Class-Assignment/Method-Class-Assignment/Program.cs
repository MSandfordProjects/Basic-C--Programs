using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method of the console app, instantiate the class.
            MathOperation Operation = new MathOperation();
            //write on the screen asking to pick a number
            Console.WriteLine("Please pick a number: ");
            //input that as number1
            int number1 = Convert.ToInt32(Console.ReadLine());
            //write on the screen asking to pick another number
            Console.WriteLine("Please pick another number: ");
            //input that as number2
            int number2 = Convert.ToInt32(Console.ReadLine());

            //Call the method in the class, passing in two numbers. 
            Operation.MathMethod(number1, number2);

            //could also do Operation.MathMethod(12, 10); with preset numbers instead of asking for numbers.

            //Call the method in the class, specifying the parameters by name.
            Operation.MathMethod(number1: number1, number2: number2);

        }
    }
}
