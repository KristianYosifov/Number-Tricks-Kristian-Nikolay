using System;
namespace NumberTricks
{
    public class NumberUtils
    {
        public NumberUtils()
        {

        }

        public static double FastExponentiate(double a, int power)
        {
            if (power == 0) return 1;
            double halfPowered = FastExponentiate(a, power / 2);
            double subTotal = halfPowered * halfPowered;
            return power % 2 == 0 ? subTotal : subTotal * a;
        }
	

        public static float SquareRoot(float n)
        {

            float x = n;
            float y = 1;
            double e = 0.000001;
            while (x - y > e)
            {
                x = (x + y) / 2;
                y = n / x;
            }
            return x;
        }
        public static List<int> Divisors(int num)
        {
            List<int> div = new List<int>();

            for (int i = 1; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    div.Add(i);
                    if (i != num / i)
                    {
                        div.Add(num / i);
                    }
                }
            }

            div.Sort();
            return div;
        }


        public static void SieveOfEratosthenes(int n)
        {
            bool[] prime = new bool[n + 1];
            for (int i = 0; i <= n; i++)
            {
                prime[i] = true;
            }
            for (int p = 2; p * p <= n; p++)
            {
                if (prime[p] == true)
                {
                    for (int i = p * p; i <= n; i += p)
                        prime[i] = false;
                }
            }
            for (int i = 2; i <= n; i++)
            {
                if (prime[i] == true)
                {
                    Console.Write(i + " ");
                }
            }
        }


    }
}

    


