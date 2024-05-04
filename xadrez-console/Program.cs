using System;
using System.Globalization;
using System.Collections.Generic;
using tabuleiro;
using xadrez;

namespace Xadrezconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 1));

                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 4));

                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 5));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e) 
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();

        }
    }
}