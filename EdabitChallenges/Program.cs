namespace EdabitChallenges;

internal class Program
{
    static void Main(string[] args)
    {
        var result = Medium.RemoveSmallest([5, 3, 2, 1, 4]).ConcatToString(",");
        Console.WriteLine(result);

        Console.ReadLine();
    }
}