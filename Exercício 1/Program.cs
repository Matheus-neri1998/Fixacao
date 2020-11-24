using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex. 1) Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
            ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu) */

            string [] anoatual = new string[1];
            string [] anodenascimento = new string [1];

            for (int i = 0; i < anoatual.Length; i++)
            {
                Console.WriteLine("Qual o ano atual? ");
                anoatual[i] = Console.ReadLine();

                for (int a = 0; a < anodenascimento.Length; a++)
                {
                    Console.WriteLine("Qual o seu ano de nascimento? ");
                    anodenascimento [i] = Console.ReadLine();
                }
                if (anoatual != anodenascimento)
                {
                    Console.WriteLine("Não deverá votar este ano");
                }
                 
            }
              

        }
    }
}
