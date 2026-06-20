namespace AssessmentOne
{
    public static class Check_If_A_Number_Is_Sparse
    {

        /// <summary>
        /// /a number is a sparse if its binary representation has no two consecutive bits set. 
        /// given an integer n determine whether it is sparse or not. 
        /// if number is sparse print 1 else 0
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsSparseBoll(int number)
        {
            // A number is sparse if there are no adjacent 1s in its binary representation
            // We can check this by performing a bitwise AND between the number and the number shifted right by 1
            // If the result is 0, then there are no adjacent 1s
            return (number & (number >> 1)) == 0;
        }

        public static int IsSparseOptimizedWay(int n)
        {
            return ((n & (n >> 1)) == 0) ? 1 : 0;
        }

        public static int IsSparseImprovedWay(int n)
        {
            int previousBit = 0;

            while (n > 0)
            {
                int currentBit = n % 2;

                if (currentBit == 1 && previousBit == 1)
                {
                    return 0;
                }

                previousBit = currentBit;
                n /= 2;
            }

            return 1;
        }

        public static int IsSparseLessEfficientWay(int n)
        {
            string binary = Convert.ToString(n, 2);

            for (int i = 0; i < binary.Length - 1; i++)
            {
                if (binary[i] == '1' && binary[i + 1] == '1')
                {
                    return 0;
                }
            }

            return 1;
        }
    }
}
