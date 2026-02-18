using System;

public class MyMath
{
    public const double PI = 3.14;
    public const double E = 2.71;
    public double Abs(double value)
    {
        return value < 0 ? -value : value;
    }

    public float Abs(float value)
    {
        return value < 0 ? -value : value;
    }

    public int Abs(int value)
    {
        return value < 0 ? -value : value;
    }
    
    public double Pow(double x, double y)
    {
        return Math.Pow(x, y);
    }

    public double Sqrt(int d)
    {
        return Math.Sqrt(d);
    }

    public int Max(int val1, int val2)
    {
        return val1 > val2 ? val1 : val2;
    }

    public int Min(int val1, int val2)
    {
        return val1 < val2 ? val1 : val2;
    }
}
