namespace Aula07.EstruturasCondicionaisCSharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=========================================");
        Console.WriteLine("Condicional simples");
        
        int numero1 = 10;
        
        Console.WriteLine("Bom dia");

        if (numero1 < 5)
        {
            Console.WriteLine("Boa tarde");
        }
        
        Console.WriteLine("Boa noite");
        
        
        Console.WriteLine("=========================================");
        Console.WriteLine("Condicional composta");
        
        Console.WriteLine("Entre com u mnúmero inteiro:");
        int numero2 = int.Parse(Console.ReadLine());

        if (numero2 % 2 == 0)
        {
            Console.WriteLine("Par!");
        }
        else
        {
            Console.WriteLine("Impar!");
        }
        
        Console.WriteLine("=========================================");
        Console.WriteLine("Condicional Encadeada");

        Console.WriteLine("Qual a hora atual?");
        int hora = int.Parse(Console.ReadLine());

        if (hora < 12)
        {
            Console.WriteLine("Bom dia!");
        }
        else if (hora < 18)
        {
            Console.WriteLine("Bom tarde!");
        }
        
        
    }
}