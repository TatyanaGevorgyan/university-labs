
using System;

namespace ConsoleApp2
{
    internal class SquareMatrix
    {
        public int N { get; set; }
        public int A { get; set; }
        public int B { get; set; }

        private int[,] matrix;

        public SquareMatrix(int n, int a, int b)
        {
            N = n;
            A = a;
            B = b;

            FillMatrix();
        }

        private void FillMatrix()
        {
            matrix = new int[N, N];
            Random random = new Random();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = random.Next(A, B + 1);
                }
            }
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }

                Console.WriteLine();
            }
        }

        public int GetOddNumberCount()
        {
            int count = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
