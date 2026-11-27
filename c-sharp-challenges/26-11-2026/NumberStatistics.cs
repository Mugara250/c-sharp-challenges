namespace c_sharp_challenges._26_11_2026;

using System;

public static class NumberStatistics
{
    public static int? FindSecondLargest(int[] numbers)
    {
        if (numbers is null) throw new ArgumentNullException();

        if (numbers == Array.Empty<int>()) return null;

        if (numbers.Distinct().ToList().Count == 1) return null;

        int largest = numbers.Max();

        int secondLargest = 0;
        
        foreach (var j in numbers)
        {
            if (j == largest) continue;
            secondLargest = j;
        }

        foreach (var t in numbers)
        {
            if (t == largest || t == secondLargest) continue;
            if (t > secondLargest)
            {
                secondLargest = t;
            }
        }

        return secondLargest;
    }
}

/*1. Return the second-largest **distinct** number in the array.
2. If the array contains fewer than two distinct numbers, return `null`.
3. Negative numbers must be supported.
4. If the array is `null`, throw `ArgumentNullException`.
5. Do not sort the array. Find the answer by traversing it.*/

