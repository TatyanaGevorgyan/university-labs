using System;
using ConsoleApp2;
class Program
{
    static void Main(string[] args)
    {
        int n = 4;
        int a = 1;
        int b = 25;

        SquareMatrix squareMatrix = new SquareMatrix(n,a,b);
        squareMatrix.ShowMatrix();
        int oddCount = squareMatrix.GetOddNumberCount();
        Console.WriteLine(oddCount);

    }
}
