using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exlgc_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valor = 0.0f;

            Console.WriteLine("Digite um valor qualquer!");
            valor = float.Parse(Console.ReadLine());
            float out1 = valor - 1.0f;
            Console.WriteLine(out1);
            Console.ReadLine();
        }
    }
}
