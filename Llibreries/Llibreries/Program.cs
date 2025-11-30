using System;
using Tools;

public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine(
            Utils.ValidateNum(10) + "\n" +
            Utils.ValidateNum(-5) + "\n" +
            Utils.ValidateNumPairOdd(4) + "\n" +
            Utils.ValidateNumRange(15) + "\n" +
            Utils.ValidatePrimeNumber(7)
            );

    }
}