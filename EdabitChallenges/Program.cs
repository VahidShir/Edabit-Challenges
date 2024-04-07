using System.Linq;

namespace EdabitChallenges;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Easy.SameCase("hello"));
        Console.WriteLine(Easy.SameCase("HELLO"));
        Console.WriteLine(Easy.SameCase("Hello"));

        Console.ReadLine();
    }
}
