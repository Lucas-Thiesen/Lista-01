using System;

namespace lista._01.consoleapp
{
    internal class Program
    {
        static void Main(string[] args)

            //• A imobiliária Imóbilis vende apenas terrenos retangulares.
            //Faça um algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno.
        {
            double testada, profundidade, area;
            Console.WriteLine("Imobiliaria imobilis!");
            Console.WriteLine("Digite a testada: ");
            testada = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a profundidade: ");
            profundidade = Convert.ToDouble(Console.ReadLine());

            area = profundidade * testada;

            Console.WriteLine("A área do terreno é de: "  + area);
            Console.ReadLine();

        }
    }
}
