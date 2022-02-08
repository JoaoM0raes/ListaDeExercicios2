using System;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int NúmeoroUm;

                int calculo;

                Console.WriteLine("Escolha seu Núemero");

                NúmeoroUm = Convert.ToInt32(Console.ReadLine());

                calculo = NúmeoroUm % 2;

                if (calculo == 0)
                {
                    Console.WriteLine("O Número é par");                   
                }
                else
                {
                    Console.WriteLine("O Número é ímpar");             
                }
            }
          
            
        }
    }
}
