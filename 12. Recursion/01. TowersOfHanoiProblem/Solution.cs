using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._12._Recursion._01._TowersOfHanoiProblem
{
    public static class Solution
    {
        private const int NumPegs = 3;
        private static readonly List<string> Operations = new();

        public static List<string> ComputeTowerHanoi(int numRings)
        {
            var pegs = new List<Stack<int>>();

            for (var i = 0; i < NumPegs; i++)
            {
                pegs.Add(new Stack<int>());
            }
            
            // Initialize pegs.
            for (var i = numRings; i >= 1; --i)
            {
                pegs[0].Push(i);
            }

            ComputeTowerHanoiSteps(numRings, pegs, 0, 1, 2);

            return Operations;
        }

        private static void ComputeTowerHanoiSteps(int numRingsToMove, IReadOnlyList<Stack<int>> pegs, 
            int fromPeg, int toPeg, int usePeg)
        {
            if (numRingsToMove <= 0)
            {
                return;
            }
            
            ComputeTowerHanoiSteps(numRingsToMove -1, pegs, fromPeg, usePeg, toPeg);

            var from = pegs[fromPeg].Pop();
            pegs[toPeg].Push(@from);
            Operations.Add("Move " + @from + " from peg " + fromPeg + " to peg " + toPeg);
                
            ComputeTowerHanoiSteps(numRingsToMove -1, pegs, usePeg, toPeg, fromPeg);
        }
    }
}