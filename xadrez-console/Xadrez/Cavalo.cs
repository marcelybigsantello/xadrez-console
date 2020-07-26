using tabuleiro;
using tabuleiro.Enums;


namespace Xadrez
{
    class Cavalo : Peca
    {

        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);
            
            pos.DefinirValores(Posicao.linha - 1, Posicao.coluna - 2);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //nordeste
            pos.DefinirValores(Posicao.linha - 2, Posicao.coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //Direita
            pos.DefinirValores(Posicao.linha - 2, Posicao.coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //Sudeste
            pos.DefinirValores(Posicao.linha - 1, Posicao.coluna + 2);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //Abaixo
            pos.DefinirValores(Posicao.linha + 1, Posicao.coluna + 2);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //Sudoeste
            pos.DefinirValores(Posicao.linha + 2, Posicao.coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //Esquerda
            pos.DefinirValores(Posicao.linha + 2, Posicao.coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //Noroeste
            pos.DefinirValores(Posicao.linha + 1, Posicao.coluna - 2);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            return mat;

        }

        public override string ToString()
        {
            return "C";
        }


    }
}
