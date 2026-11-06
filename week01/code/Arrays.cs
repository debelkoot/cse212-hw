public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        /*
         * PLAN:
         * 1. Create a new array of doubles using the given length.
         * 2. Use a for loop to go through all positions in the array.
         * 3. Multiply the given number by (i + 1) to calculate each multiple.
         * 4. Put each calculated multiple into its correct position in the array.
         * 5. After the loop finishes, return the array.
         */
        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result;
    }
    /// <summary>
    /// Rotate the data to the right by the amount.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        /*
         * PLAN:
         * 1. Find the starting position of the items that need to move to the front.
         * 2. Use GetRange() to get the items from that position to the end of the list.
         * 3. Use RemoveRange() to remove those items from their original positions.
         * 4. Use InsertRange() to put the removed items at the beginning of the list.
         * 5. After these steps, the list will be rotated to the right.
         */
        int startIndex = data.Count - amount;
        List<int> rotatedPart = data.GetRange(startIndex, amount);
        data.RemoveRange(startIndex, amount);
        data.InsertRange(0, rotatedPart);
    }
}
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        return []; // replace this return statement with your own
    }
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    }
}
