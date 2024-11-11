using System.Data;

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
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        double[] lengthArray = new double[length];

        for (int index = 0; index < length; index++)
        {
            lengthArray[index] = number * (index + 1);
        }
        return lengthArray; 
    }
    // We need an array, for loop, and return value.
    // The array will need to hold the method parameter 'length' to adjust to the length of the multiples list.
    // The for loop needs to run as long as the index is less than the 'length'.
    // The array will equal the 'number' multiplied by the index, plus one. This way the multiplication 
    // factor will increase by one each time the loop is ran (number * 1, number * 2, number * 3...).
    // The return value will be the array (after it has been used in the for loop).


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
        
        // 1. split the list using GetRange
        // 2. insert the last part of the list according to the 'amount' into a new list using RemoveRange
        // 3. use InsertRange to add the removed section to the front of the new list
        int dataCount = data.Count;
        // not needed in this scenario
        // int dataDivision = amount % dataCount;  // number of rotation places

        List<int> endOfDataRange = data.GetRange(dataCount - amount, amount);
        data.RemoveRange(dataCount - amount, amount);
        data.InsertRange(0, endOfDataRange);
    }


    // We need a dynamic array for list manipulation.TYFRDEXSZXA
    // The data list needs to shift all the values in it according to the 'amount'
    // according to the 'amount' the data in the list will be shifted to display the last numbers, and then the rest of the list
}
