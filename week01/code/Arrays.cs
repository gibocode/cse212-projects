public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Create an array of doubles based on length variable
        var results = new double[length];

        // Create a for loop that iterates from 0 up to length (less than length)
        for (int i = 0; i < length; i++)
        {
            // Calculate the mulitple by multiplying the number by the index plus one and store it in the results array
            results[i] = number * (i + 1);
        }

        // Returns the results that contains the multiples of the number based on the length
        return results;
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
        // Copy the number of elements at the end of the list and insert them at the start
        data.InsertRange(0, data.GetRange(data.Count - amount, amount));

        // Remove the duplicated elements at the end of the list
        data.RemoveRange(data.Count - amount, amount);
    }
}
