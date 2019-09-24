using System;

namespace PassByValue
{
    public class Program
    {
        static void Cube(int x)
        {
            x = x * x * x;
            Console.WriteLine("Value Within the cube method : {0}", x);
        }
        static void Main()
        {
            int num = 5;
            Console.WriteLine("Value Before the Method is called : {0}", num);
            Cube(num);
            Console.WriteLine("Value After the Method is called : {0}", num);
            Console.ReadKey();
        }
    }
}
