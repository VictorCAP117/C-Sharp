using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tipo de dados no C#
            // string, int, double, bool, char, decimal, object
            // string: cadeia de caracteres, texto
            // int: número inteiro
            // double: número com ponto flutuante
            // bool: verdadeiro ou falso
            // char: um único caractere
            // decimal: número decimal de alta precisão
            // object: tipo genérico que pode conter qualquer tipo de dado

        
            var n = "Victor";
            int ww2 = 1945;
            float vel = 315.7f;
            float soma = ww2 + vel;

            Console.WriteLine("Hello, World!");
            Console.WriteLine(n);
            Console.WriteLine(ww2);
            Console.WriteLine(vel + " km/h");
            Console.WriteLine(soma);

            if (soma > 2000) {
                Console.WriteLine("true!");
            } else {
                Console.WriteLine("false!");
            }
           

            dynamic cor = "Vermelho";
            Console.WriteLine(cor);

            cor = 255;
            Console.WriteLine(cor);

                Console.ReadLine();
        }
    }
}
