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
}