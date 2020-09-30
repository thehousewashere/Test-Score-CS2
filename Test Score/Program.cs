using System;

namespace Test_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Grade: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
           
            string g2 = Console.ReadLine();
            int g = Convert.ToInt32(g2);

            if (g >= 90)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("A");
            }
            else if (g >= 80)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("B");
            }
            else if (g >= 70)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("C");
            }
            else if (g >= 60)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("D");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("F");
            }

            Console.ForegroundColor = ConsoleColor.Gray;


        }
    }
}
