using System;

namespace Exercício_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
            15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
            declarado.*/

            float[] numeros = new float[15];

            for (var i = 0; i < 15; i++){
                Console.WriteLine();
                Console.WriteLine($"Digite {i + 1}º número (para número decimal use vírgula ao invés de ponto): \n");
                numeros[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("-----------------");
            Console.WriteLine();
            Console.WriteLine("Sua lista com os números em ordem invertida em que digitou é: \n");

            for (var i = 14; i >= 0; i--)
            {
                Console.WriteLine();
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("---------------");
        }
    }
}
