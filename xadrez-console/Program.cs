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
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab);

                    Console.Write("\n\nOrigem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                    partida.ExecutarMovimento(origem, destino);
                }
                
            }
            catch(TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
