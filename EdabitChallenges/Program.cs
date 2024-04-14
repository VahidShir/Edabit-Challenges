using System.Linq;

namespace EdabitChallenges;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Easy.CountClaps("ClaClaClaClap!"));
        Console.WriteLine(Easy.CountClaps("CCClaClClap!Clap!ClClClap!") );

        Console.ReadLine();
    }
}
