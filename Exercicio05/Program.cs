using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra ou frase: ");
        string entrada = Console.ReadLine().ToLower();

        string semEspacosEAcentos = RemoverAcentos(Regex.Replace(entrada, @"[^a-zA-Z0-9]", ""));
        string reverso = new string(semEspacosEAcentos.Reverse().ToArray());

        if (semEspacosEAcentos == reverso)
            Console.WriteLine("É um palíndromo!");
        else
            Console.WriteLine("Não é um palíndromo.");
    }

    static string RemoverAcentos(string texto)
    {
        var normalized = texto.Normalize(NormalizationForm.FormD);
        var builder = new StringBuilder();

        foreach (var c in normalized)
        {
            var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
            if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                builder.Append(c);
        }

        return builder.ToString().Normalize(NormalizationForm.FormC);
    }
}
