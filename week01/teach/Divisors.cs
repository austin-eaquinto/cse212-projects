public static class Divisors {
    /// <summary>
    /// Entry point for the Divisors class
    /// </summary>
    public static void Run() {
        List<int> list = FindDivisors(80);
        Console.WriteLine("<List>{" + string.Join(", ", list) + "}"); // <List>{1, 2, 4, 5, 8, 10, 16, 20, 40}
        List<int> list1 = FindDivisors(79);
        Console.WriteLine("<List>{" + string.Join(", ", list1) + "}"); // <List>{1}
    }

    /// <summary>
    /// Create a list of all divisors for a number including 1
    /// and excluding the number itself. Modulo will be used
    /// to test divisibility.
    /// </summary>
    /// <param name="number">The number to find the divisor</param>
    /// <returns>List of divisors</returns>
    private static List<int> FindDivisors(int number) {
        List<int> results = new();
        // TODO problem 1

        // set the variable, 
        // the loop will run while i is less than number, 
        // each time the loop runs add to i
        for (int i = 0; i < number; ++i)
        {   
            // % returns the remainder of a division
            // if the remainder isn't equal to 0
            if (number % i == 0)
            {
                // then add i (the remainder?) to results (the list)
                results.Add(i);
            }
        }
        return results;
    }
}