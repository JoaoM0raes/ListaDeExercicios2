using System;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NúmeroUm;
            int NúmeroDois;
            int Resultado;

            Console.WriteLine("Escreva o Primeiro Número");

            NúmeroUm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escreva o Segundo Número");

            NúmeroDois= Convert.ToInt32(Console.ReadLine());

            

            if (NúmeroUm== NúmeroDois)            
            {

                Resultado = NúmeroUm + NúmeroDois;
                Console.WriteLine("Números iguais a Soma é: " + Resultado  );

            }
            else
            {
                Resultado = NúmeroUm * NúmeroDois; 
                Console.WriteLine("Números diferentes a multiplicação é: " + Resultado);
            } 
        }
    }
}
