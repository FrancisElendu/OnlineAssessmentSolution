using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentOne
{
    public static class Diagonal_Difference
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int n = arr.Count;

            int primarySum = 0;
            int secondarySum = 0;

            for (int i = 0; i < n; i++)
            {
                primarySum += arr[i][i];
                secondarySum += arr[i][n - 1 - i];
            }

            return Math.Abs(primarySum - secondarySum);
        }
    }
}
