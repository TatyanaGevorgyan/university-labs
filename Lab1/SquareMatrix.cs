using System;
namespace ConsoleApp2
{
    internal class SquareMatrix
    {
        private int n;
        private int a;
        private int b;
        private int[,] matrix;
        public int N
        {
            get => n;
            set => n = value;
           

        }
        public int A
        {
            get => a;
            set => a = value;

        }
        public int B
        {
            get => b;
            set => b = value;

        }
        public SquareMatrix(int n, int a, int b)
        {
            this.n = n;
            this.a = a;
            this.b = b;
            FillMatrix();
        }
        private void FillMatrix()
        {
            matrix = new int[n, n];
            Random rand = new Random();
            for(int i =0; i < n; i++)
            {
                for(int j = 0; j<n; j++)
                {
                    matrix[i, j] = rand.Next(a, b + 1);

                }
            }

        }
        public void ShowMatrix()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i,j],4} ");

                }
                Console.WriteLine();
            }
        }
        public int GetOddNumberCount()
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                        count++;
              } 
            }
            return count;
        }
    }
}
