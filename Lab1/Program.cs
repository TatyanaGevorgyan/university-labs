using System;
using ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        int n = 3;
        int a = 3;
        int b = 17;

        SquareMatrix squareMatrix = new SquareMatrix(n, a, b);

        Console.WriteLine("Generated Matrix:");
        squareMatrix.ShowMatrix();

        int oddCount = squareMatrix.GetOddNumberCount();

        Console.WriteLine("The count of odd numbers: " + oddCount);
    }
}
