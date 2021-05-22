
using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews.HashTables.Collatz
{
    public class Solution
    {
        public static bool TestCollatzConjecture(int n)
        {
            // Stores odd numbers already tested to converge to 1.
            var verifiedNumbers = new HashSet<long>();
            
            // Starts from 3, since hypothesis holds trivially for 1 and 2.
            for (var i = 3; i <= n; i += 2)
            {
                var sequence = new HashSet<long>();
                long testI = i;

                while (testI >= i)
                {
                    if (!sequence.Add(testI))
                    {
                        // We previously encountered testI, so the Collatz sequence
                        // has fallen into a loop. This disproves the hypothesis , so
                        // we short-circuit, returning false.
                        return false;
                    }

                    if ((testI % 2) != 0) // Odd number
                    {
                        if (!verifiedNumbers.Add(testI))
                        {
                            // testI has already been verified to converge to 1.
                            break;
                        }

                        var nextTestI = 3 * testI + 1; // Multiply by 3 and add 1.
                        if (nextTestI <= testI)
                        {
                            throw new ArithmeticException("Collatz sequence overflow for " + i);
                        }

                        testI = nextTestI;
                    }
                    else
                    {
                        // Even number, halve it.
                        testI /= 2; 
                    }
                }
            }

            return true;
        }
    }
}