using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercício
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            int idade = 0;
            string xp = "";
            string sexo = "";
            int daqui = 0;

            Console.WriteLine("Cadastro para vaga de emprego!");
            Console.WriteLine("É necessário ser do sexo masculino e ter 22 anos ou mais!");
            Console.WriteLine("Preferível ter experiência.");

            Console.WriteLine("Digite seu nome!");
            nome = Console.ReadLine();

            Console.WriteLine($"{nome}, quantos anos você tem?");
            idade = int.Parse(Console.ReadLine());
            daqui = 22 - idade;

            Console.WriteLine($"{nome}, qual é o seu sexo?");
            Console.WriteLine("Digite M para masculino ou F para feminino.");
            sexo = Console.ReadLine().ToUpper();

            Console.WriteLine($"Você já trabalhou na área, {nome}?");
            Console.WriteLine("Digite S para sim ou N para não.");
            xp = Console.ReadLine().ToUpper();

            if (idade >= 22 && sexo == "M")
            {
                Console.WriteLine($"Parabéns, {nome}, você está apto para está vaga!");
            }
            else if (idade < 22)
            {
                Console.WriteLine($"Desculpe, {nome}, mas você ainda não está apto para está vaga, tente daqui {daqui} anos!");
            }
            else
            {
                Console.WriteLine($"Desculpe, {nome}, mas você não está apta para esta vaga!");
            }
            Console.ReadLine();
        }
    }
}
