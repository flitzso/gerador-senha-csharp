using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string senhaAleatoria = GerarSenhaAleatoria(8);
        Console.WriteLine("Senha Gerada: " + senhaAleatoria);
    }

    static string GerarSenhaAleatoria(int comprimento)
    {
        const string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        Random random = new Random();

        return new string(Enumerable.Repeat(caracteresPermitidos, comprimento)
          .Select(s => s[random.Next(s.Length)]).ToArray());
    }
}