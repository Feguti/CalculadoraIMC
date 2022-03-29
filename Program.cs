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

            double imc = Math.Round(peso / (altura * altura), 2);

            Console.WriteLine("\n{0} sua altura é {1} e seu peso é {2}", nome, altura, peso);
            Console.WriteLine("Seu IMC é {0}", imc);

            if(imc < 17)
            {
                Console.WriteLine("Você está muito abaixo do peso");
            }
            else if(imc >= 17 || imc < 18.50)
            {
                Console.WriteLine("Você está abaixo do peso");
            }
            else if(imc >= 18.50 || imc < 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if(imc >= 25 || imc < 30)
            {
                Console.WriteLine("Acima do peso");
            }
            else if(imc >= 30 || imc < 35)
            {
                Console.WriteLine("Obesidade I");
            }
            else if(imc >= 35 || imc < 40)
            {
                Console.WriteLine("Obesidade II (Severa)");
            }
            else if(imc > 40)
            {
                Console.WriteLine("Obesidade III (Mórbida)");
            }

        }
    }
}
