using System;

namespace Exercício_6
{
    class Program
    {
        static void Main(string[] args)
        {
        /* Exercício 6-) Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
        lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
        pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
        entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário. */

         string[] nomes = new string[5];
         string namesearch;
         bool busca = false;

         Console.ForegroundColor = ConsoleColor.Red;
         Console.WriteLine("-------------");
         Console.WriteLine("Welcome! ");
         Console.WriteLine("-------------");
         Console.ResetColor();

         for (var i = 0; i < nomes.Length; i++)
         {
            Console.WriteLine($"Digite o {i + 1}º nome: "); 
            nomes[i] = Console.ReadLine();
         }
         Console.WriteLine("Digita o nome que você deseja buscar: ");
         namesearch = Console.ReadLine();

         for (var i = 0; i < nomes.Length; i++)
         {
            if (nomes[i] == namesearch){
               Console.WriteLine("ACHEI!");
               busca = true;
               break;
                
            }
         }
         if (busca == false){
             Console.WriteLine("NÃO ACHEI!");
         }

        }
    }
}
