using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W01__First
{
    public class GraziCalc
    {
        /// <summary>
        /// 
        /// </summary>
        public static void GrazerCalc()
        {
            //variables
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            //input one
            Console.Write("\n Give the width of the window : ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            //input two
            Console.Write("\n Give the height of the window : ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            //calculation
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            //display
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
        }
    }
}

