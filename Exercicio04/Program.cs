using System;

class Program
{
    static void Main()
    {
        int opcao = 0;

        while (opcao != 3)
        {
            Console.WriteLine("Bem vindo ao SuperMegaHiper conversor de Celsius e Fahrenheit 3000!");
            Console.WriteLine("ESCOLHA UMA OPÇÃO: ");
            Console.WriteLine("1 - Celsius para Farhenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("Digite uma opção válida: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                
                Console.Write("Digite a temperatura em Celsius: ");
                double celsius = double.Parse(Console.ReadLine());
                double fahrenheit = (celsius * 9/5) +32;
                Console.WriteLine($"A temperatura de {celsius}°C equivale a  {fahrenheit}°F \n");
                break;

                case 2:

                Console.Write("Digite a temperatura em Fahrenheit: ");
                fahrenheit = double.Parse(Console.ReadLine());
                celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"A temperatura de {fahrenheit}°F equivale a {celsius}°C \n");
                break;

                case 3:
                Console.WriteLine("Saindo ... Volte em breve!");
                break;

                default:
                Console.WriteLine("Opção inválida! \n");
                break;
            }
        }
    }
}