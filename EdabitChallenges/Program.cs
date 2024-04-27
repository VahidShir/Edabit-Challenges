using System.Linq;

namespace EdabitChallenges;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Medium.FindLargest([[4, 2, 7, 1], [20, 70, 40, 90], [1, 2, 0]]).ConcatToString(", "));

        Console.ReadLine();
    }
}