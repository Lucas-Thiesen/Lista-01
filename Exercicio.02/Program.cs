using System;

namespace Exercicio._02
{
    internal class Program
    {
        static void Main(string[] args)
            //• A padaria Hotpão vende uma certa quantidade de pães franceses
            //e uma quantidade de broas a cada dia.Cada pãozinho custa R$ 0,12
            //e a broa custa R$ 1,50. Ao final do dia,
            //o dono quer saber quanto arrecadou com a venda dos pães e broas (juntos),
            //e quanto deve guardar numa conta de poupança (10% do total arrecadado).
            //Você foi contratado para fazer os cálculos para o dono.
            //Com base nestes fatos, faça um algoritmo para ler as quantidades de pães e de broas,
            //e depois calcular os dados solicitados.
        {
            const decimal PrecoDoPao = 0.12m;
            const decimal PrecoDaBroa = 1.50m;
            decimal paes, broas, valorBroa, valorPaes, total = 0.0m, poupanca;
            Console.WriteLine("Algoritmo da padaria quentepao: ");
            Console.WriteLine("Quantas Broas foram vendidas HOJE?: ");
            broas = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Quantos paes foram vendidos HOJE?: ");
            paes = Convert.ToDecimal(Console.ReadLine());

            valorBroa = broas * PrecoDaBroa;
            valorPaes = paes * PrecoDoPao;

            total = valorBroa + valorPaes;
            poupanca = total * 0.1m;

            Console.WriteLine("O total vendido HOJE foi: " + total);
            Console.WriteLine("O valor que será destinado a poupança é de: " + poupanca);
            
            Console.ReadKey();




        }
    }
}
