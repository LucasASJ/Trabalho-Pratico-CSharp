using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101); 
        int tentativas = 0;
        int palpite;

        Console.WriteLine("Bem-vindo ao Jogo da Adivinhação!");
        Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

        do
        {
            Console.Write("Digite seu palpite: ");
            
            while (!int.TryParse(Console.ReadLine(), out palpite));
            {
                Console.Write("Por favor, digite um número válido: ");
            }

            tentativas++;
            
            if (palpite < numeroSecreto)
            {
                Console.WriteLine("O número secreto é MAIOR!");
            }
            else if (palpite > numeroSecreto)
            {
                Console.WriteLine("O número secreto é MENOR!");
            }

        } while (palpite != numeroSecreto);

        Console.WriteLine($"\nParabéns! :) Você acertou em ({tentativas}) tentativas!");
    }
}
