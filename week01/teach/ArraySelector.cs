public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        // creates the results array
        var result = new int[select.Length];
        // initializes the variables to 0
        var list1Index = 0;
        var list2Index = 0;
        // sets i to 0, 
        // runs while i is less than the length of select array, 
        // starts with i then adds to it
        for (var i = 0; i < select.Length; i++)
        {
            // if the specific index of the select array =1
            if (select[i] == 1)
                // result specific index = list1 specific index addition
                result[i] = list1[list1Index++];    // the ++ after the variable means
                                                    // it gets the value, then adds to it
            // else if the specific index does not =1 (in this case it =2)
            else
                result[i] = list2[list2Index++];
        }
        // returns the new array
        return result;
    }
}