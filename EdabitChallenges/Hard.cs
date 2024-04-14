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
}