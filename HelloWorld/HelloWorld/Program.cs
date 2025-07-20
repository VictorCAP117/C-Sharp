using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nome = "Victor Santos";

            Console.WriteLine("Hello, World!"); //para quebrar linha podemos usar o 'Line' (WriteLine)
            Console.Write("Meu nome é Victor Santos!\n"); //Ou podemos usar \n no final do texto
            Console.WriteLine(nome);
            Console.Write(nome);
            Console.ReadLine(); 
        }
    }
}
