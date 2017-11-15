using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class FibonacciSequence
    {
        /// <summary>
        /// Generate Fibonacci sequence with input amount.
        /// </summary>
        /// <param name="amount">Amount of elements in sequence.</param>
        /// <returns></returns>
        public static IEnumerable<int> GenerateFibonacci(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException($"{nameof(amount)} must be greater than zero.");
            }

            int prePrevious = 0;
            int previous = 1;
            int current;

            yield return prePrevious;

            if (amount > 1)
            {
                yield return previous;
            }

            for (int i = 2; i < amount; i++)
            {
                current = previous + prePrevious;
                prePrevious = previous;
                previous = current;

                yield return current;
            }
        }
    }
}
