using System.Numerics;

namespace DonkiApi.Services
{
    public class FibonacciService : IFibonacciService
    {
        public string GetFibonacciSequence(int numberOfNumbers)
        {
            var fibonacciSequence = new List<BigInteger>();
            var currentFibonacciNumber = BigInteger.Zero;
            var previousFibonacciNumber = BigInteger.Zero;
            BigInteger twoPreviousFibonacciNumber;
            for (int i = 0; i < numberOfNumbers; i++)
            {
                fibonacciSequence.Add(currentFibonacciNumber);
                twoPreviousFibonacciNumber = previousFibonacciNumber;
                previousFibonacciNumber = currentFibonacciNumber;
                if (twoPreviousFibonacciNumber.IsZero && previousFibonacciNumber.IsZero)
                {
                    currentFibonacciNumber = BigInteger.One;
                }
                else
                {
                    currentFibonacciNumber = BigInteger.Add(twoPreviousFibonacciNumber, previousFibonacciNumber);
                }
            }
            return string.Join(", ", fibonacciSequence);
        }
    }
}
