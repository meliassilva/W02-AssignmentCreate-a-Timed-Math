﻿using System;

namespace Newreverse
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the Number of the Elements you Want to Hold in the Array? ");
            string s = Console.ReadLine();
            int x = Int32.Parse(s);
            int[] a = new int[x];
            Console.WriteLine("\n Enter Array Elements : ");
            for (int i = 0; i < x; i++)
            {
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }

            Array.Reverse(a);
            Console.WriteLine("Reversed Array : ");

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Element {0} is {1}", i + 1, a[i]);
            }
            Console.Read();

        }
    }
}
