using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exlgc_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x = 0.0f;
            float y = 0.0f;

            Console.WriteLine("Calculo de área de retângulo");
            Console.Write("Altura:");
            y = float.Parse(Console.ReadLine());

            Console.Write("Largura:");
            x = float.Parse(Console.ReadLine());

            float xy = x * y;

            Console.WriteLine($"Área: {xy}");

            if (x == y) {
            Console.WriteLine("É um quadrado");
            } else {
                Console.WriteLine("É um retângulo");
            }

            Console.ReadLine();
        }
    }
}
