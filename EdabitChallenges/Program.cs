using System.Linq;

namespace EdabitChallenges;

internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine(string.Join(',',Easy.FindMinMax([1])));
        Console.WriteLine(string.Join(',',Easy.FindMinMax([1, 2, 3, 4, -55])));
        Console.WriteLine(string.Join(',',Easy.FindMinMax([-10, 0, 0, 2])));

        Console.ReadLine();
    }
}
