using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int i = 0;
            while (suma <= 100)
            {
                suma += i;
                if (suma < 100)
                {
                    i++;
                }

            }
            Console.WriteLine("Trzeba dodać do siebie {0} liczb", i);
        }
    }
}
