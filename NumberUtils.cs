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
			double halfPowered = FastExponentiate(a, power/2);
			double subTotal = halfPowered * halfPowered;
			return power % 2 == 0 ? subTotal : subTotal * a;
		}
	}


        
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
}
