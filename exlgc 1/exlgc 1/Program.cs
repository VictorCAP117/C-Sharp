using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exlgc_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 10;
            int B = 20;

            Console.WriteLine($"A = {A}, B = {B}, inverta os valores!");
            Console.Write("A = ");
            A = int.Parse(Console.ReadLine());
            Console.Write("B = ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine($"A = {A}");
            Console.WriteLine($"B = {B}");

            if (A == 20 && B == 10) {
                Console.WriteLine("Parabéns, está correto!");
            } else {
                Console.WriteLine("Tente novamente!");
            }
        }
    }
}
