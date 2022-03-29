using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fala tu parça, qual seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("\nMe diz a sua altura, em metros de preferência. Ex: 1,70");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nQuanto você pesa? Ex: 70,3");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("\n{0} sua altura é {1} e seu peso é {2}", nome, altura, peso);
            Console.WriteLine("Seu IMC é {0}", Math.Round(imc));
        }
    }
}
