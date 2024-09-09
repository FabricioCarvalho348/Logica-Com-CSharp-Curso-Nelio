namespace Aula08.FuncoesCSharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite três números:");
        int n1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite três números:");
        int n2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite três números:");
        int n3 = int.Parse(Console.ReadLine());

        double resultado = Maior(n1, n2, n3);

        Console.WriteLine("Maior = " + resultado);
        
        // === Criação da Função Maior para este código ===
        // if (n1 > n2 && n1 > n3)
        // {
        //     Console.WriteLine("Maior = " + n1);
        // }
        // else if (n2 > n3)
        // {
        //     Console.WriteLine("Maior = " + n2);
        // }
        // else
        // {
        //     Console.WriteLine("Maior = " + n3);
        // }
    }

    static int Maior(int n1, int n2, int n3)
    {
        int maior;
        if (n1 > n2 && n1 > n3)
        {
            maior = n1;
        }
        else if (n2 > n3)
        {
            maior = n2;
        }
        else
        {
            maior = n3;
        }

        return maior;
    }
}