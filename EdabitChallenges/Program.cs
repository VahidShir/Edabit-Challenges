using System.Collections.Generic;

namespace EdabitChallenges;

internal class Program
{
    static void Main(string[] args)
    {
        Hard.WeekAfter(@"01/06/1947");
        Console.WriteLine(VeryHard.TrackRobot(steps: "..<.<.").ConcatToString(", "));

        Console.ReadLine();
    }

}