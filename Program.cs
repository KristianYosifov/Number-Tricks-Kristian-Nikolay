﻿namespace NumberTricks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine(NumberUtils.FastExponentiate(2, 3));


            Console.WriteLine(NumberUtils.SquareRoot(4));         
            Console.ReadKey();


            Console.WriteLine("SieveOfEratosthenes:");
            int n = int.Parse(Console.ReadLine());
            NumberUtils.SieveOfEratosthenes(n);



            int num = Convert.ToInt32(Console.ReadLine());
            List<int> divisors = NumberUtils.Divisors(num);
            Console.WriteLine($"Divisors of {num}: {string.Join(", ", divisors)}");

        }
    }
}
