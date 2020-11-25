using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 3-) Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o preço unitário. 
            Calcular e escrever o total (total = quantidade adquirida * preço unitário), odesconto e o total a pagar 
            (total a pagar = total - desconto), sabendo-se que:
            - Se quantidade <= 5 o desconto será de 2%
            - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
            - Se quantidade > 10 o desconto será de 5%  */

             Console.WriteLine("Digite o nome do produto:");
             string nomedoProduto = Console.ReadLine();

             Console.WriteLine("Insira a quantidade desejada:");
             int quantidade = int.Parse(Console.ReadLine());

             Console.WriteLine("Insira o valor do produto:");
             float preço = int.Parse(Console.ReadLine());

             TotalAPagar(nomedoProduto,quantidade,preço);

            float totalAPagar = TotalAPagar(nomedoProduto,quantidade,preço);

            if (totalAPagar >=100){
                Console.WriteLine("Ganhará um brinde");
            }else{
                Console.WriteLine("Ganhará adesivos colecionáveis");
            }

             float TotalAPagar (string nome, int quantidade, float preço);{

                float total = quantidade * preço;
                float desconto;
                if (quantidade <=5){
                    desconto = 0.02f; // 2%
                }else if (quantidade <=10){
                    desconto = 0.03f; // 3%
                }else{
                    desconto = 0.05f;
                }
                float valorDoDesconto = total * desconto;
                float totalcomDesconto = total - valorDoDesconto;

                Console.WriteLine($"Sua compra ficou em R$ {total}");
                Console.WriteLine($"Você irá receber R$ {valorDoDesconto}");
                Console.WriteLine($"Sua compra com desconto ficou em R$ {totalcomDesconto}");

                return totalcomDesconto ;
                
             } // fim de TotalAPagar
        }
    }
}
