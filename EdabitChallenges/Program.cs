using System.Linq;

namespace EdabitChallenges;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(string.Join(',', Easy.SortNumsAscending([12, 5, 50])));

        Console.ReadLine();
    }
}
