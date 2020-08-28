using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula 02");

            String nome = "Yago santos";
            int ano = 2020;
            int nasc = 1993;
            int idade;

            idade = ano - nasc;
            Console.WriteLine("O " + nome + "Tem: " + idade + "anos.");

            double peso = 4.0;
            int quantidade = 10;
            System.Console.WriteLine(peso * quantidade);

            int a= 15 , b= 2;
            System.Console.WriteLine(a / b);

            Console.ReadLine();
            


        }
    }
}
