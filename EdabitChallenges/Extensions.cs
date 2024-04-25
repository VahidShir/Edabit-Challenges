namespace EdabitChallenges;

public static class Extensions
{
    public static string ConcatToString<T>(this IEnumerable<T> input)
    {
        return string.Concat(input);
    }

    public static string ConcatToString<T>(this IEnumerable<T> input, string separator)
    {
        return string.Join(separator, input);
    }
}