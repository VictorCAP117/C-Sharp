using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exlgc_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cinco = 0;
            int dez = 0;
            int vinte5 = 0;
            int cinquenta = 0;
            int cem = 0;
            float reais = 0.0f;
            int cent = 0;
            int moedas = 0;
            float media = 0.0f;

            while (true)
            {

                Console.Write("Centavos (Digite 0 para sair): ");
                cent = int.Parse(Console.ReadLine());
                if (cent == 0)
                {
                    break;
                }
                else
                    moedas++;
                if (cent == 5)
                {
                    cinco = cinco + 5;
                }
                else if (cent == 10)
                {
                    dez = dez + 10;
                }
                else if (cent == 25)
                {
                    vinte5 = vinte5 + 25;
                }
                else if (cent == 50)
                {
                    cinquenta = cinquenta + 50;
                }
                else if (cent == 100 || cent == 1)
                {
                    cem = cem + 100;
                }
                else
                {
                    moedas--;
                    Console.WriteLine("Valor inválido. Insira um valor válido de centavos (5, 10, 25, 50, 100).");
                    continue;
                }
            }
            cent = cinco + dez + vinte5 + cinquenta + cem;
            reais = cent / 100.0f;
            media = cent / (float)moedas;

            Console.WriteLine();
            Console.WriteLine($"Total de moedas: {moedas}");
            Console.WriteLine($"Valor total: R${reais}");
            Console.WriteLine($"Média por moeda: {media}");

        }
    }
}
