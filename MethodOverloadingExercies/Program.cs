using System;

namespace MethodOverloadingExercies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 3));
            Console.WriteLine(Add(4.2, 5.3));
            Add(1, 0, true);

        }
            

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static string Add(int a, int b, bool c)
        {
            if (c == true && (a + b) == 1)
            {
                Console.WriteLine($"{a + b} dollar.");
            }
            else if (c == true && (a + b) > 1)
            {
                Console.WriteLine($"{a + b} dollars.");
            }
            else if (!c || (a + b) < 1)
                Console.WriteLine("invalid entry");
        

                return "invalid entry";
        }
    }
}
