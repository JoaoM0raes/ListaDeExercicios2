using System;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valorOne;
            string valorTwo;
            string valorThree;

            int A;
            int B;
            int C;

            int[] array = new int[3];

            

            while (true) 
            {

                Console.WriteLine("Escreva o valor 1");
                valorOne = Console.ReadLine();

                Console.WriteLine("Escreva o valor 2");
                valorTwo = Console.ReadLine();

                Console.WriteLine("Escreva o valor 3");
                valorThree = Console.ReadLine();

                A = Convert.ToInt32(valorOne);
                B = Convert.ToInt32(valorTwo);
                C = Convert.ToInt32(valorThree);

                if (A == B || A == C || B==C )
                {
                    Console.WriteLine("Favor colocar números diferentes");
                    continue;
                    
                }
                array[0] = A;
                array[1] = B;
                array[2] = C;

                Array.Sort(array);
                Array.Reverse(array);

                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("A ordem decrescente é: " + array[i]);
                }

            } 

         


        }
    }
}
