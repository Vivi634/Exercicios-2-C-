// programa soma dois valores inteiros e calcula a média
using System;

namespace ConsoleApp
{
    class Programa
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;
            Console.WriteLine ("Some dois valores inteiros e calcule a média ! ");
    
            Console.WriteLine("Informe o 1º numero= ");
            n1= int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2º numero= ");
            n2= int.Parse(Console.ReadLine());

            Console.Write("A média será =  ");

            resultado= (n1 + n2) /2;

            Console.Write(resultado);

            Console.ReadKey();
         
                        
        }
    }
}



