using System;

namespace BecaMatriz
{
    class DiagonalPrincipal
    {
        public void CalculaSomaDiagonalPrincipal_Paula()
        {

            int[,] matriz = new int[,] {
                { 2, 5, 9 },
                { 5, 20, 8 },
                { 8, 12, 16 }
            };

            int totalSoma = 0;

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(0); coluna++)
                {

                    if (linha == coluna)
                    {
                        totalSoma = totalSoma + matriz[linha, coluna];
                    }
                }
            }
            Console.WriteLine("Soma dos valores da diagonal principal: " + totalSoma);
            Console.Read();
        }
    }
}
