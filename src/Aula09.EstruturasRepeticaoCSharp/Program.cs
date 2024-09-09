using System.Globalization;

namespace Aula09.EstruturasRepeticaoCSharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("================================================================");
        Console.WriteLine("Estrutura De Repetição - WHILE");
        
        Console.Write("Digite um número: ");
        double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        while (x >= 0.0)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
            Console.Write("Digite outro número: ");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        
        Console.WriteLine("Número negativo");
        
        Console.WriteLine("================================================================");
        Console.WriteLine("Estrutura De Repetição - FOR");
        
        Console.Write("Quantos números inteiros você vai digitar? ");
        int numeroParaRepeticao = int.Parse(Console.ReadLine());

        int soma = 0;
        for (int i = 1; i <= numeroParaRepeticao; i++)
        {
            Console.WriteLine("Valor: #{0}: ", i);
            int valor = int.Parse(Console.ReadLine());
            soma += valor;
        }
        
        Console.WriteLine("Soma = " + soma);
        
    }
}