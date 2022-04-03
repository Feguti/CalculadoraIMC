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

            Console.WriteLine("\n{0} sua altura é {1}m e seu peso é {2}Kg", nome, altura, peso);
            Console.WriteLine("Seu IMC é {0}", imc);

            if(imc < 17)
            {
                Console.WriteLine("Você está muito abaixo do peso\n");
            }
            else if(imc >= 17 && imc < 18.50)
            {
                Console.WriteLine("Você está abaixo do peso\n");
            }
            else if(imc >= 18.50 && imc < 25)
            {
                Console.WriteLine("Peso normal\n");
            }
            else if(imc >= 25 && imc < 30)
            {
                Console.WriteLine("Você está acima do peso\n");
            }
            else if(imc >= 30 && imc < 35)
            {
                Console.WriteLine("Obesidade I\n");
            }
            else if(imc >= 35 && imc < 40)
            {
                Console.WriteLine("Obesidade II (Severa)\n");
            }
            else
            {
                Console.WriteLine("Obesidade III (Mórbida)\n");
            }

            if(imc < 18.50)
            {
                double peso_ideal = 18.50 * (altura * altura);
                double peso_necessario = Math.Round(peso_ideal - peso, 2);

                Console.WriteLine("Você precisa ganhar {0}Kg", peso_necessario);
            }

            else if(imc >= 25)
            {
                double peso_ideal = 24.99 * (altura * altura);
                double peso_necessario = Math.Round(peso - peso_ideal, 2);

                Console.WriteLine("Você precisa perder {0}Kg", peso_necessario);
            }
        }
    }
}
