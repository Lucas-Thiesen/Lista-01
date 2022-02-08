using System;

namespace Exercicio._05
{
    internal class Program
    {
        static void Main(string[] args)
            //Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%.
            //Após o aumento, desconte 8% de impostos.Imprima o salário inicial,
            //o salário com o aumento e o salário final.
        {
            const decimal valorAumento = 0.15m;
            const decimal impostos = 0.8m;

            decimal salarioAtual, salarioAumento, salarioFinal;

            Console.Write("Digite o seu salário: ");
            salarioAtual = Convert.ToDecimal(Console.ReadLine());

            salarioAumento = salarioAtual + salarioAtual * valorAumento;

            salarioFinal = salarioAumento - salarioAumento * impostos;

            Console.WriteLine("o salário com aumento é de: " + salarioAumento);
            Console.WriteLine("O salário final é: " + salarioFinal);

            Console.ReadKey();
        }
    }
}
