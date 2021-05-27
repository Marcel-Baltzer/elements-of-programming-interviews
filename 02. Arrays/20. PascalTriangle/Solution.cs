using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._02._Arrays._20._PascalTriangle
{
    public class Solution
    {
        public static List<List<int>> GeneratePascalTriangle(int numRows)
        {
            var pascalTriangle = new List<List<int>>();

            for(var i = 0; i < numRows; i++)
            {
                var currRow = new List<int>();
                for(var j = 0; j <= i; j++)
                {
                    // Set this entry to the sum of the two above adjacent entries 
                    // if they adjacent entries if they exist.
                    currRow.Add((0 < j && j < i)
                        ? pascalTriangle[i-1][j-1] + pascalTriangle[i-1][j] 
                        : 1);

                }
                pascalTriangle.Add(currRow);
            }

            return pascalTriangle;
        }
    }
}