using System.Collections.Generic;

namespace EdabitChallenges;

internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine(VeryHard.TrackRobot(steps: "..<.<.").ConcatToString(", "));

        Console.ReadLine();
    }

}