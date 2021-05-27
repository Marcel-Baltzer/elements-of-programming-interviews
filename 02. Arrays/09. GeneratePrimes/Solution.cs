using System;
using System.Collections.Generic;
using System.Linq;

namespace Elements_of_Programming_Interviews._02._Arrays._09._GeneratePrimes
{
    public class Solution
    {
        public static List<int> GeneratePrimes(int n)
        {
            var primes = new List<int>();
            
            // isPrime[p] represents if p is prime or not. Initially , set each
            // to true, excepting 0 and 1. Then use sieving to eliminate non primes.
            var isPrime = Enumerable.Repeat(true, n+1).ToList();
            isPrime[0] = false;
            isPrime[1] = false;

            for(var p = 0; p <= n; p++)
            {
                if(isPrime[p])
                {
                    primes.Add(p);
                    // Sieve p’s multiples.
                    for(var j = p; j<=n; j += p)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            return primes;
        }

        public static List<int> GeneratePrimesOptimization(int n)
        {
            var size = (int)Math.Floor(0.5 * (n-3)) + 1;
            var primes = new List<int> {2};

            // isPrime[i] represents whether (2i + 3) is prime or not.
            // Initially, set each to true. Then use sieving to eliminate non primes.
            var isPrime = Enumerable.Repeat(true, size).ToList();

            for(var i = 0; i < size; i++)
            {
                if(isPrime[i])
                {
                    var p = (i * 2) + 3;
                    primes.Add(p);

                    // Sieving from p^2, whose value is (4i^2 + 12i + 9). The index of this
                    // value in isPrime is (2i^2 + 6i + 3) because isPrime[i] represents 2i + 3.
                    //
                    // Note that we need to use long type for j because p^2 might overflow.
                    for(long j = ((i*i)*2) + 6*i + 3; j < size; j +=p)
                    {
                        isPrime[(int)j] = false;
                    }
                }
            }

            return primes;
        }
    }
}