using System;

namespace Exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Exercício 4-) Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o menor valor lido. */

            // Variáveis declaradas 
           double [] valores = new double [10];
           double maior = 0;
           double menor = 1000;

           Console.WriteLine("Digite dez valores: ");
           for (var i = 0; i < 10; i++)
           {
               valores[i] = double.Parse(Console.ReadLine());
               if (valores[i] > maior)
               {
                   maior = valores[i];
               }
               if (valores[i] < menor)
               {
                   menor = valores[i];
               }
           } // fim de for

           Console.Write("O menor valor diigtado é de ");
           Console.ForegroundColor = ConsoleColor.Red;
           Console.Write(menor);
           Console.ResetColor();
           Console.Write("O maior valor digitado é de ");
           Console.ForegroundColor = ConsoleColor.Green;
           Console.Write(maior);
           Console.ResetColor();
        } // fim de Main
    }
}
