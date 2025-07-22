using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            float n1 = 0f;
            float n2 = 0f;
            float n3 = 0f;
            string operacao = "";

            Console.WriteLine("Escreva seu nome:");
            nome = Console.ReadLine();
            /*
            Console.WriteLine("Olá, " + nome + "! Dígite o primeiro número");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            n2 = float.Parse(Console.ReadLine());
            float n3 = n1 + n2;
            Console.WriteLine(nome + ", o resuldado da soma de " + n1 + " + " + n2 + " é: " + (n3));
            */
            Console.WriteLine(nome + ", ecolha a operação (+, -, *, /)");
            operacao = Console.ReadLine();
            Console.WriteLine(nome + ", digite o primeiro número!");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine(nome + ", digite o segundo número!");
            n2 = float.Parse(Console.ReadLine());

            if (operacao == "+") {
                n3 = n1 + n2;
            } else if (operacao == "-") {
                n3 = n1 - n2;
            } else if (operacao == "*") {
                n3 = n1 * n2;
            } else if (operacao == "/") {
                n3 = n1 / n2;
            }

            Console.WriteLine(nome + ", o resultado de " + n1 + " " + operacao + " " + n2 + " é: " + n3);

            Console.ReadLine();
        }
    }
}
