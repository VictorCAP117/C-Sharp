using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Cadastro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            int idade = 0;
            float desconto = 0;
            float valor = 0.0f;
            float valorFinal = 0.0f;
            float resto = 0.0f;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write($"Quantos anos você tem, {nome}? ");
            idade = int.Parse(Console.ReadLine());

            if (idade < 18)
            {
                Console.WriteLine($"Sinto muito, {nome}, mas você não pode comprar aqui por ser menor de idade!");
            }
            else
            {
                Console.Write($"{nome}, qual o valor da compra? ");
                valor = float.Parse(Console.ReadLine());

                if (idade >= 60)
                {
                    desconto = valor * 20 / 100;
                    valorFinal = valor - desconto;
                    resto = valor - valorFinal;
                    
                    Console.WriteLine($"{nome}, você recebeu um desconto de 20% na sua compra!");
                    Console.WriteLine($"O valor de R${valor:F2} passa a ser R${valorFinal:F2}, você economizou R${resto:F2}!");
                }
                else if (idade >= 30 && idade <= 59)
                {
                    desconto = valor * 10 / 100;
                    valorFinal = valor - desconto;
                    resto = valor - valorFinal;

                    Console.WriteLine($"{nome}, você recebeu um desconto de 10% na sua compra!");
                    Console.WriteLine($"O valor de R${valor:F2} passa a ser R${valorFinal:F2}, você economizou R${resto:F2}!");

                }
                else
                {
                    Console.WriteLine($"{nome}, o valor da compra é R${valor:F2}");
                }
            }
        }
    }
}
