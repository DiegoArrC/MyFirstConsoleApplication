using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Diego";
            string location = "Las Vegas";

            Console.WriteLine($"My name is {name} and I am from {location}.");

            // Datetime object for today
            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate.ToString("MM/dd/yyyy"));

            // Datetime object for Christmas this year.
            DateTime christmas = new DateTime(DateTime.Now.Year, 12, 25);
            
            // Calculate the time (and therefore days) between today and Christmas
            TimeSpan timeUntilChristmas = christmas.Subtract(currentDate);
            double daysUntilChristmas = timeUntilChristmas.TotalDays;

            // If today is after Christmas in the current year, do the calculation to next Christmas
            if (daysUntilChristmas < 0)
            {
                daysUntilChristmas = 365 - daysUntilChristmas;
            }

            Console.WriteLine($"There are {daysUntilChristmas:F0} until Christmas");


            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("Enter a width for the wood:");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Enter a height for the wood");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();


        }
    }
}
