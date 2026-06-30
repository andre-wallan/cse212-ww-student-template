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
        // TODO Problem 1 Start
        // Plan:
        // 1. Create an array of doubles with size 'length'.
        // 2. For each index i from 0 to length-1, compute the (i+1)th multiple of 'number' as number * (i+1).
        // 3. Store that value into the array at index i.
        // 4. After filling the array, return it.

        double[] multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;
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
        // Plan:
        // 1. Let n be the number of elements in 'data'. If n is 0, return immediately.
        // 2. Reduce the rotation amount with modulo: k = amount % n. If k == 0, the list stays the same.
        // 3. Take the last k elements (the tail) and the first n-k elements (the head).
        // 4. Clear the original list and append the tail followed by the head so the list is rotated right by k.
        // This modifies the provided list in-place.

        int n = data.Count;
        if (n == 0)
        {
            return;
        }

        int k = amount % n;
        if (k == 0)
        {
            return;
        }

        List<int> tail = data.GetRange(n - k, k);
        List<int> head = data.GetRange(0, n - k);

        data.Clear();
        data.AddRange(tail);
        data.AddRange(head);
    }
}
