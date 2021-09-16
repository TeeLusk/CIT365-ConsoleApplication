using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Tyler";
            var location = "Rexburg, Idaho";

            Console.WriteLine($"My name is  {name}");
            Console.WriteLine($"I am from {location}");

            DateTime today = DateTime.Now;

            Console.WriteLine($"Today's date is: {today.ToShortDateString()}");

            DateTime Christmas = new DateTime(2021, 12, 25);

            var untilChristmas = (Christmas.DayOfYear - today.DayOfYear);

            Console.WriteLine($"There are {untilChristmas} days until Christmas");

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Please input a width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please input a height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
             woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
             glassArea + " square metres");

            Console.WriteLine("Hit any key to exit");
            Console.ReadKey();
        }
    }
}
