using System;
using System.Globalization;

namespace OMaior
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, MAIORAB, MAIOR;

            string[] valores = Console.ReadLine().Split(' ');
            A = int.Parse(valores[0]);
            B = int.Parse(valores[1]);
            C = int.Parse(valores[2]);

            MAIORAB = (A + B + Math.Abs(A - B))/ 2;
            MAIOR = (MAIORAB + C + Math.Abs (MAIORAB - C))/ 2;

            Console.WriteLine(MAIOR + " eh o maior");
            Console.ReadLine();
        }
    }
}
