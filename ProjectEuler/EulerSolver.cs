using System;
using System.Linq;
using System.Numerics;

namespace ProjectEuler
{
    /// <summary>
    ///     mawak / Shield@42
    /// </summary>
    public class EulerSolver
    {
        public int Problem1()
        {
            var sum = 0;
            for (var i = 0; i < 1000; i++)
            {
                if (i%3 == 0 || i%5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        // fibonacci: 1, 2, 3, 5, 8, 13, 21, 34, 55, 89,
        public int Problem2()
        {
            var first = 0;
            var second = 1;
            var fibonacci = 0;
            var sum = second;
            var max = 4000000;

            Console.WriteLine(first);
            Console.WriteLine(second);

            while (true)
            {
                if (fibonacci%2 == 0)
                {
                    sum += fibonacci;
                }
                fibonacci = first + second;
                if (fibonacci > max)
                    break;

                Console.WriteLine(fibonacci);

                first = second;
                second = fibonacci;
            }

            return sum;
        }

        /// <summary>
        ///     The prime factors of 13195 are 5, 7, 13 and 29.
        ///     Calculate the largest Prime of 600851475143
        /// </summary>
        /// <returns></returns>
        public int Problem3()
        {
            var number = 600851475143;
            //long number = 13195;

            var limit = (int) Math.Sqrt(number);
            var p = new Prime();
            var primes = p.SieveOfEratosthenes(limit).ToList();
            var max = 0;
            for (var i = primes.Count() - 1; i > 0; i--)
            {
                if (number%primes[i] == 0)
                {
                    //Console.WriteLine("{0} is prime", primes[i]);
                    max = primes[i];
                    break;
                }
            }

            return max;
        }

        public int Problem3_1()
        {
            var num = 600851475143L;
            long sum = 0;

            for (var i = 2; i < num; i++)
                while (num%i == 0)
                {
                    num = num/i;
                    sum = num;
                }
            return ((int) sum);
        }

        public int Problem3_2()
        {
            BigInteger a = 600851475143;

            for (BigInteger i = 2; i < a; i++)
            {
                if (a%i == 0)
                {
                    a = a/i;
                }
            }
            return (int) a;
        }

        //A palindromic number reads the same both ways.
        //The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        //Find the largest palindrome made from the product of two 3-digit numbers.
        public int Problem4()
        {
            var palindrome = 0;
            for (var i = 999; i >= 100; i--)
            {
                for (var j = i; j >= 100; j--)
                {
                    var product = i*j;
                    var s = product.ToString();
                    if (s.Equals(new string(s.Reverse().ToArray())))
                    {
                        //Debug.WriteLine("{0} {1} {2}",i,j,product);
                        palindrome = product > palindrome ? product : palindrome;
                    }
                }
            }
            return palindrome;
        }

        //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        //What is the smallest positive number that is evenly divisible (with no remainder) by all of the numbers from 1 to 20?
        //
        // 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20
        // 
        // answer = 232792560
        public int Problem5()
        {
            var max = 1L*2*3*4*5*6*7*8*9*10*11*12*13*14*15*16*17*18*19*20;
            long found = 0;

            for (var i = 1; i <= max && found == 0; i++)
            {
                for (var j = 20; j >= 2; j--)
                {
                    if (i%j != 0)
                    {
                        break;
                    }
                    if (j == 2)
                    {
                        found = i;
                        break;
                    }
                }
            }

            return (int) found;
        }

        //The sum of the squares of the first ten natural numbers is,
        //1**2 + 2**2 + ... + 10**2 = 385
        //The square of the sum of the first ten natural numbers is,
        //(1 + 2 + ... + 10)**2 = 552 = 3025
        //Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
        //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        //
        // //////answer = 25164150
        public int Problem6()
        {
            long sumOfSquares = 0;
            long squareOfSum = 0;
            for (var i = 1; i <= 100; i++)
            {
                sumOfSquares += i*i;
                squareOfSum += i;
            }
            squareOfSum *= squareOfSum;
            return (int) (squareOfSum - sumOfSquares);
        }

        //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        //What is the 10 001st prime number?
        public int Problem7()
        {
            var limit = 120000;
            var p = new Prime();
            var primes = p.SieveOfEratosthenes(limit).ToList();
            //var util = new Utility();
            //util.WriteEnumerable(primes);

            var prime1001 = primes[10000];
            return prime1001;
        }
    }
}