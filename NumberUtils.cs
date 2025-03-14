using System;

public class Class1
{
	public Class1()
	{
        
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
