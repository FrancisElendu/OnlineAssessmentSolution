namespace AssessmentOne
{
    public static class Maximizing_Game_Piece_Moves
    {
        //public static int solution(int[] board)
        //{
        //    // Null check
        //    if (board == null)
        //        throw new ArgumentNullException(nameof(board));

        //    int n = board.Length;

        //    // Length constraint
        //    if (n < 1 || n > 40000)
        //        throw new ArgumentOutOfRangeException(nameof(board), "Length must be between 1 and 40,000.");

        //    // Step 1: collect indices of all pieces (1s)
        //    List<int> onesPositions = new List<int>();

        //    for (int i = 0; i < n; i++)
        //    {
        //        // Value constraint
        //        if (board[i] != 0 && board[i] != 1)
        //            throw new ArgumentException("Array must contain only 0s and 1s.");

        //        if (board[i] == 1)
        //            onesPositions.Add(i);
        //    }

        //    int k = onesPositions.Count;
        //    if (k == 0) return 0;

        //    // Step 2: Move all pieces to the LEFT
        //    int leftDistance = 0;
        //    for (int i = 0; i < k; i++)
        //    {
        //        leftDistance += Math.Abs(onesPositions[i] - i);
        //    }

        //    // Step 3: Move all pieces to the RIGHT
        //    int rightDistance = 0;
        //    for (int i = 0; i < k; i++)
        //    {
        //        rightDistance += Math.Abs(onesPositions[i] - (n - k + i));
        //    }

        //    return Math.Max(leftDistance, rightDistance);
        //}

        //another implementation with O(n) time complexity and O(1) space complexity
        public static int solution(int[] board)
        {
            if (board == null)
                throw new ArgumentNullException(nameof(board));

            int n = board.Length;

            if (n < 1 || n > 40000)
                throw new ArgumentOutOfRangeException(nameof(board));

            // Step 1: Count total number of 1s
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (board[i] != 0 && board[i] != 1)
                    throw new ArgumentException("Array must contain only 0s and 1s.");

                if (board[i] == 1)
                    k++;
            }

            if (k == 0) return 0;

            int leftDistance = 0;
            int rightDistance = 0;

            int onesSeen = 0;

            // Step 2: Compute distances in one pass
            for (int i = 0; i < n; i++)
            {
                if (board[i] == 1)
                {
                    // LEFT target = onesSeen
                    leftDistance += Math.Abs(i - onesSeen);

                    // RIGHT target = (n - k + onesSeen)
                    rightDistance += Math.Abs(i - (n - k + onesSeen));

                    onesSeen++;
                }
            }

            return Math.Max(leftDistance, rightDistance);
        }
    }
}
