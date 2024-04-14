namespace EdabitChallenges;

public static class Extensions
{
    public static string ConcatString(this IEnumerable<char> input)
    {
        return string.Concat(input);
    }
}