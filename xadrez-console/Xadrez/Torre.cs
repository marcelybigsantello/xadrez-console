using tabuleiro;
using tabuleiro.Enums;

namespace Xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
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

            //acima
            pos.DefinirValores(Posicao.linha - 1, Posicao.coluna);
            while(Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                if(Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.linha -= 1;
            }

            //abaixo
            pos.DefinirValores(Posicao.linha + 1, Posicao.coluna);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.linha += 1;
            }

            //Direita
            pos.DefinirValores(Posicao.linha, Posicao.coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.coluna += 1;
            }

            //esquerda
            pos.DefinirValores(Posicao.linha, Posicao.coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.coluna -= 1;
            }
            return mat;
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
