public class Pessoa
{
    public string Nome { get; set; }

    public double Altura { get; set; }

    public double Peso { get; set; }

    public double IMC { get => Math.Round(Peso / (Altura * Altura), 2);}

    public Pessoa(string nome, double altura, double peso)
    {
        Peso = peso;
        Altura = altura;
        Nome = nome;
    }

    public void setNome(string nome) 
    {
        this.Nome = nome;
    }

    public void setAltura(double altura) 
    {
        this.Altura = altura;
    }

    public void setPeso(double peso) 
    {
        this.Peso = peso;
    }


    public string resultado()
    {
        if(IMC < 17)
        {
            return "Você está muito abaixo do peso\n";
        }
        else if(IMC >= 17 && IMC < 18.50)
        {
            return "Você está abaixo do peso\n";
        }
        else if(IMC >= 18.50 && IMC < 25)
        {
            return "Peso normal\n";
        }
        else if(IMC >= 25 && IMC < 30)
        {
            return"Você está acima do peso\n";
        }
        else if(IMC >= 30 && IMC < 35)
        {
            return "Obesidade I\n";
        }
        else if(IMC >= 35 && IMC < 40)
        {
            return "Obesidade II (Severa)\n";
        }
        else
        {
            return"Obesidade III (Mórbida)\n";
        }
    }

    public double necessario()
    {

        if(IMC < 18.50)
        {
            double peso_ideal = 18.50 * (Altura * Altura);
            double peso_necessario = Math.Round(peso_ideal - Peso, 2);

            Console.WriteLine("Você precisa ganhar:");
            return peso_necessario;
        }

        else if(IMC >= 25)
        {
            double peso_ideal = 24.99 * (Altura * Altura);
            double peso_necessario = Math.Round(Peso - peso_ideal, 2);

            Console.WriteLine("Você precisa perder:");
            return peso_necessario;
        }
        else
        {
            Console.WriteLine("Você não precisa ganhar nem perder peso");
            return 0;
        }
    }
}