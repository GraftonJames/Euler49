// See https://aka.ms/new-console-template for more information
using System.Globalization;

namespace Euler_FourtyNine {
    class Program 
    {
        static void Main()
        {
            int[] primes = GenPrimes(1000 ,10000);
            List<int[]> candidateTriples = new();
            foreach (int prime in primes)
            {
                if (primes.Contains(prime + 3330) && primes.Contains(prime + 6660))
                {
                    candidateTriples.Add(new int [] {prime, prime + 3330, prime + 6660});
                }
            }
            foreach (int[] ct in candidateTriples)
            {
                Console.WriteLine($"{ct[0]},{ct[1]},{ct[2]}");
            }
            //list is now short enough to manually check in a few mins.
        }
        static int[] GenPrimes(int lowerBound, int upperBound)
        {
            List<int> numbers = Enumerable.Range(2,upperBound).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count;)
                {
                    if (numbers[j] % numbers[i] == 0)
                    {
                        numbers.Remove(numbers[j]);
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            while(numbers[0] < lowerBound)
            {
                numbers.Remove(numbers[0]);
            }
            return numbers.ToArray();
        }
    } 
}