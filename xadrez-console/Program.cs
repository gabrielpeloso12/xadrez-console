using System;
using System.Globalization;
using System.Collections.Generic;
using tabuleiro;

namespace Xadrezconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(3, 4);

            Console.WriteLine("Posição: " + P);

            Console.WriteLine();

        }
    }
}