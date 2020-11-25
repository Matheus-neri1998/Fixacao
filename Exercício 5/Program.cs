using System;

namespace Exercício_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Tabuada;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Veja a tabuada: ");
            // Console.WriteLine("-------------");
            Console.ResetColor();

            for (var i = 1; i <= 10; i++)
            {
            Console.WriteLine("-------------");
                for (var j = 1; j <= 10; j++)
                {
                    Tabuada = i * j;
                    Console.WriteLine($"{i} * {j} + {Tabuada}");

                }                
            }
        }
    }
}
