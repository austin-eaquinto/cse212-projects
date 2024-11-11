/// <summary>
/// These 3 functions will (in different ways) calculate the standard
/// deviation from a list of numbers.  The standard deviation
/// is defined as the square root of the variance.  The variance is 
/// defined as the average of the squared differences from the mean.
/// </summary>
public static class StandardDeviation {
    public static void Run() {
        var numbers = new[] { 600, 470, 170, 430, 300 };
        Console.WriteLine(StandardDeviation1(numbers)); // Should be 147.322 
        Console.WriteLine(StandardDeviation2(numbers)); // Should be 147.322 
        Console.WriteLine(StandardDeviation3(numbers)); // Should be 147.322 
    }

    private static double StandardDeviation1(int[] numbers) {
        // O(n)
        var total = 0.0;
        var count = 0;
        foreach (var number in numbers) {   // O(n) time. n is length of numbers array.
            total += number;    // O(1)
            count += 1; // O(1)
        }

        var avg = total / count;    // O(1)
        var sumSquaredDifferences = 0.0;
        foreach (var number in numbers) {   //O(n)
            sumSquaredDifferences += Math.Pow(number - avg, 2); //O(1)
        }

        var variance = sumSquaredDifferences / count;   // O(1)
        return Math.Sqrt(variance);
    }

    private static double StandardDeviation2(int[] numbers) {
        // O(n^2)
        var sumSquaredDifferences = 0.0;
        var countNumbers = 0;
        foreach (var number in numbers) {   // iterates once for each element in number array. runs n times where n is the length of the array.
            var total = 0;
            var count = 0;
            foreach (var value in numbers) {    // also iterates over all elements in numbers array. runs n times for each iteration of the outer loop.
                total += value;
                count += 1;
            }

            var avg = total / count;    // constant time operation O(1), after inner loop finishes
            sumSquaredDifferences += Math.Pow(number - avg, 2); // O(1), after average is computed
            countNumbers += 1;
        }

        var variance = sumSquaredDifferences / countNumbers;    // O(1)
        return Math.Sqrt(variance); // O(1)
    }

    private static double StandardDeviation3(int[] numbers) {   // O(n)
        var count = numbers.Length;     // constant time operation O(1)
        var avg = (double)numbers.Sum() / count;    // calculates sum of all elements in array. summing all elements takes O(n) time because each element must be added once. dividing the sum by the count is a constant time operation O(1).
        var sumSquaredDifferences = 0.0;
        foreach (var number in numbers) {   // loop iterates over all n elements in numbers array once.
            sumSquaredDifferences += Math.Pow(number - avg, 2); // subtracting avg from number O(1), squaring result with math.pow O(1), adding squared value to sumSquaredDifferences O(1)
        }

        var variance = sumSquaredDifferences / count;   // O(1)
        return Math.Sqrt(variance); // O(1)
    }
}