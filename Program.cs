﻿global using global::System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            //try
            //{
            //    Tabuleiro tab = new Tabuleiro(8, 8);


            //    Tela.imprimirTabuleiro(tab);
            //}
            //catch (TabuleiroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();


        }
    }
}