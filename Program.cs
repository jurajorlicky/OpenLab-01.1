using System;

namespace OpenLab_01._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int x = Int32.Parse(input);
            if (x >= 10)
                Console.WriteLine("This number is greater or equal than 10.");
            else
                Console.WriteLine("The number is less then 10");
        }
    }
}
