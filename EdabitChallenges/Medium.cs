namespace EdabitChallenges;

public static class Medium
{
    /// <summary>
    /// <see href="https://edabit.com/challenge/2QvnWexKoLfcJkSsc">Link to challenge</see>
    /// </summary>
    public static int[] ArrayOfMultiples(int num, int length)
    {
        int[] reult = new int[length];

        for (int i = 0; i < length; i++)
        {
            reult[i] = num * (i + 1);
        }

        return reult;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/2QvnWexKoLfcJkSsc">Link to challenge</see>
    /// </summary>
    public static int[] ArrayOfMultiplesV2(int num, int length)
        => Enumerable.Range(1, length).Select(x => x * num).ToArray();

    /// <summary>
    /// <see href="https://edabit.com/challenge/99oN5igrbXddAjHEL">Link to challenge</see>
    /// </summary>
    public static string ReverseCase(string input)
    {
        return string.Concat(input.Select(c => char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c)));
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/Q7g8sfg7DJq6CyMMu">Link to challenge</see>
    /// </summary>
    public static bool CheckEquality(object a, object b)
    {
        return Object.Equals(a, b);
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/6qFnpAhd3kdmYcNG2">Link to challenge</see>
    /// </summary>
    public static int[] IndexOfCapitals(string text)
    {
        var temp = text.Select((v, index) =>
        {
            if (char.IsUpper(v))
                return index;
            else
                return -1;
        });

        return temp.Where(x => x != -1).ToArray();
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/JYEufqRvkusjr5R58">Link to challenge</see>
    /// </summary>
    public static string Bomb(string text) =>
        text.Contains("bomb", StringComparison.InvariantCultureIgnoreCase) ?
            "Duck!!!" : "There is no bomb, relax.";
}