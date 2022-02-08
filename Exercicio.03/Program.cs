using System;

namespace Exercicio._03
{
    internal class Program
    {
        static void Main(string[] args)
            // Escreva um algoritmo para ler o nome e a idade de uma pessoa,
            // e exibir quantos dias de vida ela possui.Considere sempre anos completos,
            // e que um ano possui 365 dias.Ex: uma pessoa com 19 anos possui 6935 dias de vida;
            // veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.

        {
            string  nome;
            int idade, diasdevida;
            Console.WriteLine("Ensira uma moeda para ver quantos dias VOCE já viveu: ");
            Console.WriteLine("Qual o seu nome?: ");
            nome = Console.ReadLine();
            Console.WriteLine("Qual a sua idade?: ");
            idade = Convert.ToInt32(Console.ReadLine());

            diasdevida = idade * 365;

            Console.WriteLine("Querido (a): " + nome);
            Console.WriteLine("Você já viveu " + diasdevida + " dias nesta terra");

            Console.ReadKey();
        }
    }
}
