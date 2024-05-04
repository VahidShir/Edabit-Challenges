namespace EdabitChallenges;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Hard. ProductEqualTarget(new int[] { 2, 3, 5 }, 600).ConcatToString(", "));
        Console.WriteLine(Hard. ProductEqualTargetV2(new int[] { 2, 3, 5 }, 600).ConcatToString(", "));

        Console.ReadLine();
    }
}