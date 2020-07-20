using System;
using tabuleiro;
using Xadrez;
using tabuleiro.Enums;
using tabuleiro.Exceptions;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('d', 2);
            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());
            Console.ReadLine();

        }
    }
}
