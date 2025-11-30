
namespace Tools
{
    public class Utils
    {
        // Validates that the given number is positive
        public static string ValidateNum(int num)
        {
            if (num > 0)
            {
                return "Num valid (positive)";
            }
            else if (num < 0)
            {
                return "Num invalid (negative)";
            }
            else
            {
                return "Num is zero";
            }
        }

        // Validates that the given number is within the specified range
        public static string ValidateNumRange(int num, int min = 0, int max = 100)
        {
            if (num >= min && num <= max)
            {
                return $"Num valid in range {min}-{max}";
            }
            else
            {
                return $"Num invalid in range {min}-{max}";
            }
        }
        public static string ValidateNumPairOdd(int num)
        {
            if (num % 2 == 0)
                return $"{num} is PAIR";
            else
                return $"{num} is ODD";
        }

        public static string ValidatePrimeNumber(int num)
        {
            if (num <= 1)
                return "Not a prime number (must be greater than 1)";

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return $"{num} is NOT prime (divisible by {i})";
            }

            return $"{num} is a PRIME number";
        }

    }
}
