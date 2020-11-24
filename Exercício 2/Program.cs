using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o tipo de combustível? G -Gasolina ou A - Álcool");
            string tipo = Console.ReadLine();
            
            Console.WriteLine("Digite a quantidade de litros que deseja abastecer");
            float litros = float.Parse(Console.ReadLine());

            // Declarações de variáveis
                 float percentualDesconto;
                 float preçoGasolina = 4.9f;
                 float totaldoDesconto;
                 float valorBruto;
                 float valorAPagar;

            switch (tipo.ToLower())
            {
                case "g":
                        if (litros<=20)
                        {
                            percentualDesconto = 0.03f;
                        }else{
                            percentualDesconto = 0.5f;
                        }
                        totaldoDesconto = (litros * preçoGasolina) * percentualDesconto;
                        valorBruto = (litros * preçoGasolina);
                        valorAPagar = valorBruto - totaldoDesconto;
                        Console.WriteLine($"Valor a ser pago é de: {valorAPagar}");
                    break;

                case "a":
                        if (litros<=20)
                        {
                            percentualDesconto = 0.04f;
                        }else{
                            percentualDesconto = 0.06f;
                        }
                         totaldoDesconto = (litros * preçoGasolina) * percentualDesconto;
                        valorBruto = (litros * preçoGasolina);
                        valorAPagar = valorBruto - totaldoDesconto;
                        Console.WriteLine($"Valor a ser pago é de: {valorAPagar}");
                    break;

                default:
                Console.WriteLine("Valor inválido");
                    break;
            } // fim de switch
            
        } // Fim de main
            
    }
}
