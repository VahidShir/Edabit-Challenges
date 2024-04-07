using System.Reflection.Metadata.Ecma335;

namespace EdabitChallenges;

public static class Easy
{
    /// <summary>
    /// <see href="https://edabit.com/challenge/uevxL5FNM77otyo9Z">Link to challenge</see>
    /// </summary>
    /// <param name="n"></param>
    public static string MonthNameV1(int n)
    {
        string[] months = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];

        return months[n - 1];
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/uevxL5FNM77otyo9Z">Link to challenge</see>
    /// </summary>
    /// <param name="n"></param>
    public static string MonthNameV2(int n)
    {
        var date = new DateTime(2000, n, 1);

        return date.ToString("MMMM");
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/kMWmiNJM4szSv7dLd">Link to challenge</see>
    /// </summary>
    public static int[] FindMinMax(int[] nums)
    {
        return [nums.Min(), nums.Max()];
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/K49LXsoMmS6tXxP7R">Link to challenge</see>
    /// </summary>
    public static int HammingDistance(string a, string b)
    {
        return a.Zip(b, (first, second) => first == second).Count(x => x == false);
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/c4W4BNymgCC5WkfHp">Link to challenge</see>
    /// </summary>
    public static string NameShuffle(string name)
    {
        var splitted = name.Split(" ");

        return string.Join(" ", splitted.Reverse());
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/PmhP5mXMRrBoH3WoB">Link to challenge</see>
    /// </summary>
    public static int Factorial(int n)
    {
        if (n == 1)
            return 1;
        else
            return Factorial(n - 1) * n;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/PmhP5mXMRrBoH3WoB">Link to challenge</see>
    /// </summary>
    public static int FactorialV2(int n)
    {
        int result = 1;
        for (int i = n; i > 0; i--)
        {
            result *= i;
        }
        return result;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/5ytLyHsZHfyDhBgXr">Link to challenge</see>
    /// </summary>
    public static int CountVowels(string text) => text.Count(c => new char[] { 'a', 'e', 'i', 'o', 'u' }.Any(vowel => vowel == char.ToLower(c)));
}