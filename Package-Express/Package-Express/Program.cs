using System;

namespace Package_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            //Show a line that states Welcome to Package Express
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            //Show a line that states Please enter the package weight:
            Console.WriteLine("Please enter the package weight:");
            //Store PackWeight in a decimal form
            decimal PackWeight = Convert.ToDecimal(Console.ReadLine());
            //If the package weight is over 50 - exit the program
            if ( PackWeight >= 50 )
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }
            //Show a line that states Please enter the package width:
            Console.WriteLine("Please enter the package width:");
            //Stores the width value as decimal
            decimal PackWidth = Convert.ToDecimal(Console.ReadLine());
            //Show a line that states Please enter the package height:
            Console.WriteLine("Please enter the package height:");
            //Stores the height value as decimal
            decimal PackHeight = Convert.ToDecimal(Console.ReadLine());
            //Show a line that states Please enter the package length:
            Console.WriteLine("Please enter the package length:");
            //Stores the length value as decimal
            decimal PackLength = Convert.ToDecimal(Console.ReadLine());

            //take the width, height, and length and multiple them together
            decimal Dtotal = (PackWidth * PackHeight * PackLength);
            //take the total from above and multiply it by the weight
            decimal Subtotal = (Dtotal * PackWeight);
            //take the subtotal and divide by 100
            decimal total = (Subtotal / 100);
            //convert that into a curency string
            string Ftotal = total.ToString("C");

            //Show a line stating estimated total with estimated total in currnecy
            Console.WriteLine("Your estimated total for shipping this package is: " + Ftotal);
            Console.WriteLine("Thank you!");
        }
    }
}
