using System;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
     
        {
            while (true)
            {
                string mostrar = "Seu Imc é de ";
               

                float Altura;
                float Peso;
                float Imc;

                Console.WriteLine("Escreva a Altura");
                Altura = float.Parse(Console.ReadLine());
                Console.WriteLine("Escreva o Peso");
                Peso = float.Parse(Console.ReadLine());

                if (Altura > 3.50f)
                {
                    Console.WriteLine("favor colocar uma altura válida");
                    Console.Clear();
                    continue;

                }

                Imc = Peso / (Altura * Altura);

                if (Imc < 18.5f)
                {
                    Console.WriteLine(mostrar + Math.Round(Imc) + " e está Abaixo do Peso");
                }
                else if (Imc >= 18.5f && Imc <= 25)
                {
                    Console.WriteLine(mostrar + Math.Round(Imc) + " e Seu peso é Normal");
                }
                else if (Imc >= 25 && Imc <= 30)
                {
                    Console.WriteLine(mostrar + Math.Round(Imc) + " e está Acima Do Peso");
                }
                else
                {
                    Console.WriteLine(mostrar + Math.Round(Imc) + " e está Obeso");
                }
            }
           
        }
    }
}
