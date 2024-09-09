﻿using System.Globalization;

namespace Aula02.SaidaDadosCSharp;

class Program
{
    static void Main(string[] args)
    {
        int idade = 32;
        double saldo = 10.35784;
        String nome = "Maria";
        Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
        Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
        Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a "
                          + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
    }
}