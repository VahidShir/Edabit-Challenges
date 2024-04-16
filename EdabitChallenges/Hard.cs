namespace EdabitChallenges;

public static class Hard
{
    /// <summary>
    /// <see href="https://edabit.com/challenge/YGhgctqPsKQxQQCFS">Link to challenge</see>
    /// </summary>
    public static string ReverseAndNot(int n)
    {
        return string.Concat((n.ToString()).Reverse()) + n.ToString();
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/wunaXvZw3WctYioeC">Link to challenge</see>
    /// </summary>
    public static string Uncensor(string censoredText, string vowels)
    {
        int counter = 0;
        string result = "";
        foreach (var c in censoredText)
        {
            if (c == '*')
            {
                result += vowels[counter];
                counter++;
            }
            else
            {
                result += c;
            }
        }

        return result;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/wunaXvZw3WctYioeC">Link to challenge</see>
    /// </summary>
    public static string UncensorV2(string censoredText, string vowels)
    {
        char[] result = censoredText.ToArray();

        foreach (var c in vowels)
        {
            result[string.Concat(result).IndexOf("*")] = c;
        }

        return string.Concat(result);
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/wunaXvZw3WctYioeC">Link to challenge</see>
    /// </summary>
    public static string UncensorV3(string censoredText, string vowels)
    {
        Queue<char> vowelsQueue = new Queue<char>(vowels.ToArray());

        return censoredText.Select(c => c == '*' ? vowelsQueue.Dequeue() : c).ConcatString();
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/dZeNE4BJhyNgA99Fq">Link to challenge</see>
    /// </summary>
    public static string Interview(int[] times, int total)
    {
        string disqualified = "disqualified";

        //Interview(new int [] { 5, 5, 10, 10, 15, 15, 20, 20 }, 120) ➞ "qualified"
        if (total > 120)
            return disqualified;

        var timeLimit = new[] { 5, 5, 10, 10, 15, 15, 20, 20 };
        if (times.Length < timeLimit.Length)
            return disqualified;

        var passedTimes = timeLimit.Select((v, index) => times[index] <= v);
        //var exceededLimits = times.Zip(timeLimit, (a, b) => a > b);// it is another method
        if (passedTimes.Any(x => x == false))
            return disqualified;

        return "qualified";
    }
}