﻿using System;
using Tabuleiros;

namespace Xadrez
{
    internal class Bispo : Peca
    {
        public Bispo(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro)
        {

        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] movPossiveis = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            pos.DefineValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (Tabuleiro.IsPosicaoValida(pos) && IsLocalValido(pos))
            {
                movPossiveis[pos.Linha, pos.Coluna] = true;

                Peca pecaAux = Tabuleiro.RetornaPeca(pos);

                if (pecaAux != null && pecaAux.Cor != Cor)
                {
                    break;
                }

                pos.DefineValores(pos.Linha - 1, pos.Coluna - 1);
            }

            pos.DefineValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            while (Tabuleiro.IsPosicaoValida(pos) && IsLocalValido(pos))
            {
                movPossiveis[pos.Linha, pos.Coluna] = true;

                Peca pecaAux = Tabuleiro.RetornaPeca(pos);

                if (pecaAux != null && pecaAux.Cor != Cor)
                {
                    break;
                }

                pos.DefineValores(pos.Linha - 1, pos.Coluna + 1);
            }

            pos.DefineValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (Tabuleiro.IsPosicaoValida(pos) && IsLocalValido(pos))
            {
                movPossiveis[pos.Linha, pos.Coluna] = true;

                Peca pecaAux = Tabuleiro.RetornaPeca(pos);

                if (pecaAux != null && pecaAux.Cor != Cor)
                {
                    break;
                }

                pos.DefineValores(pos.Linha + 1, pos.Coluna + 1);
            }

            pos.DefineValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            while (Tabuleiro.IsPosicaoValida(pos) && IsLocalValido(pos))
            {
                movPossiveis[pos.Linha, pos.Coluna] = true;

                Peca pecaAux = Tabuleiro.RetornaPeca(pos);

                if (pecaAux != null && pecaAux.Cor != Cor)
                {
                    break;
                }

                pos.DefineValores(pos.Linha + 1, pos.Coluna - 1);
            }

            return movPossiveis;
        }

        private bool IsLocalValido(Posicao pos)
        {
            Peca peca = Tabuleiro.RetornaPeca(pos);
            return peca == null || peca.Cor != Cor;
        }

        public override string ToString()
        {
            return "B";
        }
    }
}
