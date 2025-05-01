using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem vindo ao SuperMegaHiper Tabuada 3000!");
        Console.Write("Informe um número para ver a sua tabuada: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nTabuada do {numero}");

        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }
}
