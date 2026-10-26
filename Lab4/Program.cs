using System;

    internal class Program
    {
        static int SumValues(params int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum;
        }

        static void A(in int x)
        {
            Console.WriteLine($"in value: {x}");
        }

        static void B(out int x)
        {
            x = 100;
        }

        static void C(ref int x)
        {
            x = x * 2;
        }

        static void Main(string[] args)
        {
            int yy = 44;
            int t;

            int result = SumValues(10, 20, 30, 40);
            Console.WriteLine(result);
            Console.WriteLine(SumValues(10, 20, 30, 40));
            A(in yy);
            B(out t);
            Console.WriteLine($"out t: {t}");
            C(ref yy);
            Console.WriteLine($"ref yy: {yy}");
        }
    }

