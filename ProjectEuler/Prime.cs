using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProjectEuler
{
    public class Prime
    {
        public IEnumerable<int> SieveOfEratosthenes(int limit)
        {
            // 2,3,4,5,6,7,8,9,10,11,12, ...

            // 2,3,-,5,-,7,-,9,- ,11,- ,
            var numbers = Enumerable.Repeat(true, limit).ToArray();
            numbers[0] = false;
            numbers[1] = false; // 0 and 1 are not primes


            for (var i = 2; i*i < limit; i++)
            {
                var primenumber = i;

                var counter = 2;
                var multiple = primenumber*counter;
                while (multiple < limit)
                {
                    //Debug.WriteLine("i = {0}  multiple = {1} counter = {2} ", i, multiple, counter);
                    numbers[multiple] = false; // clear all multiples of latest prime

                    counter++;
                    multiple = primenumber*counter;
                }
                //Debug.WriteLine("");
            }

            var primes = ConvertArrayToPrimes(numbers);

            return primes;
        }

        private IEnumerable<int> ConvertArrayToPrimes(bool[] numbers)
        {
            var primes = new List<int>();
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i])
                {
                    primes.Add(i);
                }
            }
            return primes;
        }
    }
}