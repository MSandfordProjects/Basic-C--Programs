using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Show a line that states Academy of learning career college
            Console.WriteLine("Academy of Learning Career College.");
            //Show a line that states Student Daily Report
            Console.WriteLine("Student Daily Report");
            //Show a line that asks for the users name
            Console.WriteLine("What is your name?");
            //Stores the name value by reading the line input - also allows for user to see answer input
            string name = Console.ReadLine();
            //Show a line that asks What course are you on
            Console.WriteLine("What course are you on?");
            //Stores the course value by reading the line input - also allows for user to see answer input
            string course = Console.ReadLine();
            //Show a line that asks What page number?
            Console.WriteLine("What page number?");
            //Stores the page number as an integer by reading the line input and converting it to an integer - also allows for user to see answer input
            int pagenumber = Convert.ToInt32(Console.ReadLine());
            //Show a line that asks Do you need help with anything? Please answer - using \ to show the quotes without breaking the code for true/false
            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\"");
            //Store helpneeded true/false input by reading the line - also allows for user to see answer input
            string helpneeded = Console.ReadLine(); 
            //Conver helpneeded value input to a boolean
            bool Bhelpneeded = bool.Parse(helpneeded);
            //Show a line that asks where there any positive experiences you'd like to share? please give specifics
            Console.WriteLine("Where there any positive experiences you'd like to share? Please give specifics.");
            //Store experiences value by reading line input - also allows for user to see answer input
            string experiences = Console.ReadLine();
            //Show a line that asks is there any other feedback you'd like to provide? please be specific
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            //Store feedback value by reading line input - also allows for user to see answer input
            string feedback = Console.ReadLine();
            //show a line that asks how many hours did you study today
            Console.WriteLine("How many hours did you study today?");
            //store studyhours by reading line input - also allows for user to see answer input
            string studyhours = Console.ReadLine();
            //Stores Istudyhours as an integer by converting studyhours into an integer
            int Istudyhours = Convert.ToInt32(studyhours);
            //show message saying Thank you for your answers. an instructor will respond to this shortly. have a great day!
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            //Allows time for individual to read line before just closing - pressing enter would also close the window.
            Console.ReadLine();
        }
    }
}
