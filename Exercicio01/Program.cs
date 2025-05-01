using System;

class Program
{
    static void Main()
    {
        bool senhaforte = false;

        while (!senhaforte)
        {
        Console.Write("Digite uma senha: ");
        string senha = Console.ReadLine();

        bool tamanho = senha.Length >= 8;
        bool maiuscula = false;
        bool numero = false;
        bool especial = false;

        string especiais = "!@#$%¨&*()_-+=";

        foreach (char c in senha)
        {
            if (char.IsUpper(c)) maiuscula = true;
            else if (char.IsDigit(c)) numero = true;
            else if (especiais.Contains(c)) especial = true;
        }
        
        if (tamanho && maiuscula && numero && especial)
        {
            Console.WriteLine("Senha Forte!");
            senhaforte = true;
        }
        else
        {
            Console.WriteLine("Senha Fraca! Ainda faltam: ");

            if (!tamanho)
                Console.WriteLine("- Faltam carácteres! Mínimo de 8.");
            if (!maiuscula)
                Console.WriteLine("Deve conter ao menos uma maiscula!");
            if (!numero)
                Console.WriteLine("Deve conter ao menos um número");
            if (!especial)
                Console.WriteLine("Deve conter ao menos um dos caractéres especiais listados (!@#$%¨&*()_-+=)");
            }
        }
    }
}