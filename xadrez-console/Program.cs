using System;
using System.Globalization;
using System.Collections.Generic;
using tabuleiro;
using xadrez_console;

namespace Xadrezconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);

            Console.WriteLine();

        }
    }
}