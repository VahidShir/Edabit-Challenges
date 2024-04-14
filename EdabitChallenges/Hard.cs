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
}