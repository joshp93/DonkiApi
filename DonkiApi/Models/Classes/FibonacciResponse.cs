namespace DonkiApi.Models.Classes
{
    public class FibonacciResponse(int numberOfNumbers, string sequence)
    {
        public int NumberOfNumbers => numberOfNumbers;
        public string Sequence => sequence;
    }
}
