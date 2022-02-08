using System;

namespace ListaDeExercicios.consoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valorOne;
            string valorTwo;
            string valorThree;

            float ValorA;
            float ValorB;
            float ValorC;
            float soma;

            Console.WriteLine("Exercicio 1");

            Console.WriteLine("Escreva o valor A ");
            valorOne = Console.ReadLine();

            Console.WriteLine("Escreva o valor B ");
            valorTwo = Console.ReadLine();

            Console.WriteLine("Escreva o valor C ");
            valorThree = Console.ReadLine();

            ValorA = float.Parse(valorOne);
            ValorB = float.Parse(valorTwo);
            ValorC = float.Parse(valorThree);

            soma = ValorA + ValorB;

            if (soma< ValorC)
            {
                Console.WriteLine("A SOMA TOTAL= " + soma + " É MENOR QUE " + ValorC);
            }
        }
    }
}
