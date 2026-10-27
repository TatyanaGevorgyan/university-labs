using System;

 class Program
    {
        static int CalculateTotal(params int[] items)
        {
            int total = 0;
            foreach (int val in items)
            {
                total += val;
            }
            return total;
        }
        static void PrintInfo(string name, int age = 18)
         {
        Console.WriteLine($"Name: {name}, Age: {age}");
         }

        static void PrintReadOnly(in int val)
        {
            Console.WriteLine($"in value: {val}");
        }

        static void AssignValue(out int val)
        {
            val = 100;
        }

        static void DoubleValue(ref int val)
        {
            val = val * 2;
        }

        static void Main(string[] args)
        {
            int num = 44;
            int resultNum;

            int outcome = CalculateTotal(10, 20, 30, 40);
            Console.WriteLine(outcome);
            Console.WriteLine(CalculateTotal(10, 20, 30, 40));
            PrintReadOnly(in num);
            AssignValue(out resultNum);
            Console.WriteLine($"out t: {resultNum}");
            DoubleValue(ref num);
            Console.WriteLine($"ref yy: {num}");
            PrintInfo("Anna");
            PrintInfo("Aram", 25);
        }
    }
