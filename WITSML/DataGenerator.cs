using System;

public class DataGenerator
{
    private static Random random = new Random();

    public static double GenerateRandomNumber(double minimum, double maximum)
    {
        return random.NextDouble() * (maximum - minimum) + minimum;
    }
}
