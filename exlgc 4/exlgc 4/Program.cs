using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exlgc_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;
            int meses = 0;
            int dias = 0;
            float totaldias = 0.0f;

            Console.Write("Quantos anos você tem? ");
            idade = int.Parse(Console.ReadLine());

            Console.Write($"{idade} anos e quantos meses? ");
            meses = int.Parse(Console.ReadLine());

            Console.Write($"{meses} meses e quantos dias? ");
            int.TryParse(Console.ReadLine(), out dias);

            totaldias = idade * 12 * 30.4166666667f + meses * 30.4166666667f + dias;

            Console.WriteLine($"Você tem {totaldias} dias de vida.");

        }
    }
}
