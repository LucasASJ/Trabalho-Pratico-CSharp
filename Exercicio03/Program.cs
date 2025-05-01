using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem-vindo ao SuperMehaHiper cálculo de fatorial 3000!");
        Console.Write("Informe um número inteiro e positivo: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine("Por favor, informe um número inteiro positivo.");
        }
        else
        {
            int fatorial = 1;
            int i = 1;

            while (i <= numero)
            {
                fatorial *= i;
                i++;
            }

            Console.WriteLine($"O fatorial de {numero} é {fatorial}.");
        }
    }
}
