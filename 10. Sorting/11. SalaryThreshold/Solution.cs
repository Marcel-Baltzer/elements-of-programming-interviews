using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._10._Sorting._11._SalaryThreshold
{
    public class Solution
    {
        public static double FindSalaryCap(double targetPayroll, List<double> currentSalaries)
        {
            currentSalaries.Sort();
            var unadjustedSalarySum = 0.0;

            for (var i = 0; i < currentSalaries.Count; i++)
            {
                var adjustedSalarySum = currentSalaries[i] * (currentSalaries.Count - i);

                if (unadjustedSalarySum + adjustedSalarySum >= targetPayroll)
                {
                    return (targetPayroll - unadjustedSalarySum) / (currentSalaries.Count - i);
                }

                unadjustedSalarySum += currentSalaries[i];
            }
            
            // No solution, since targetPayroll > existing payroll.
            return -1.0;
        }
    }
}