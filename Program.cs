Pessoa p1 = new Pessoa("Jefferson", 1.70, 65);
Pessoa p2 = new Pessoa("Carlo", 1.67, 80);

Console.WriteLine(p1.Nome);
Console.WriteLine(p1.Altura);
Console.WriteLine(p1.Peso);
Console.WriteLine(p1.IMC);
Console.WriteLine(p1.resultado());
Console.WriteLine(p1.necessario());

Console.WriteLine("-------------------");

Console.WriteLine(p2.Nome);
Console.WriteLine(p2.Altura);
Console.WriteLine(p2.Peso);
Console.WriteLine(p2.IMC);
Console.WriteLine(p2.resultado());
Console.WriteLine(p2.necessario());
