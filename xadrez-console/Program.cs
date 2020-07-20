using System;
using tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p;

            p = new Posicao(10, 6);

            Console.WriteLine("Posição: " + p);
        }
    }
}
