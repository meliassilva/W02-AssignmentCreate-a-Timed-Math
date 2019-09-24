using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W01__First
{
    /// <summary>
    /// 
    /// </summary>
    public class Program : GraziCalc
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Hello !!!! What's your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Where are you from?");
            string location = Console.ReadLine();

            Console.WriteLine("Welcome to CS367 " + name + ". I hope you enjoy the class");
            Console.WriteLine(location + " is an amazing place.");

            //grab the date today
            DateTime now = DateTime.Now;
            Console.WriteLine("Today is: " + now);

            DateTime C = Convert.ToDateTime("12/25/2019");
            TimeSpan timetoC = (C - now);
            Console.WriteLine("The number of the days until Chrystimas is: " + timetoC + ".");

            GrazerCalc();

            Console.WriteLine("\n Press any key to close the program");
            Console.ReadKey();
        }
    }
}
