namespace EdabitChallenges;

public static class VeryHard
{
    /// <summary>
    /// <see href="https://edabit.com/challenge/3wT3QcDdfvMR3amjc">Link to challenge</see>
    /// </summary>
    public static string Simplify(string fraction)
    {
        var numerator = int.Parse(fraction.Split("/")[0]);
        var denominator = int.Parse(fraction.Split("/")[1]);

        if (numerator % denominator == 0)
        {
            return (numerator / denominator).ToString();
        }
        else if (numerator == 1)
        {
            return $"{numerator}/{denominator}";
        }


        int counter = 2;
        int prime = 0;

        while (counter <= Math.Max(numerator / 2, denominator / 2))
        {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(counter); i++)
            {
                if (counter % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                prime = counter;

                if (numerator % prime == 0 && denominator % prime == 0)
                {
                    numerator /= prime; denominator /= prime;

                    return Simplify($"{numerator}/{denominator}");
                }
            }

            counter++;
        }

        return fraction;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/8JegGd37XazwMJvs6">Link to challenge</see>
    /// </summary>
    public static string FiboWord(int n)
    {
        // 1, 1, 2, 3, 5, 8, 13, 21, …,
        //FiboWord(3) ➞ "b, a, ab"

        //FiboWord(7) ➞ "b, a, ab, aba, abaab, abaababa, abaababaabaab"
        if (n < 2)
            return "invalid";

        string[] result = new string[n];

        result[0] = "b";
        result[1] = "a";

        for (int i = 2; i < n; i++)
        {
            result[i] = result[i - 1] + result[i - 2];
        }

        return result.ConcatToString(", ");
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/vtdfueRCmpRGyLAGs">Link to challenge</see>
    /// </summary>
    public static string MaxOccur(string text)
    {
        var occurences = text.GroupBy(x => x).Select(x => new { Character = x.Key, Count = x.Count() });

        var mostOccurrence = occurences.Max(x => x.Count);
        if (mostOccurrence == 1)
            return "No Repetition";
        return occurences.Where(x => x.Count == mostOccurrence).Select(x => x.Character).ConcatToString(", ");

    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/FXt7yKLgFi7SW6JBa">Link to challenge</see>
    /// </summary>
    public static double UniqueFract()
    {
        HashSet<double> divideds = new HashSet<double>();
        double sum = 0;
        for (int i = 1; i < 9; i++)
        {
            for (int j = i + 1; j <= 9; j++)
            {
                var divided = ((double)i / j);
                if (divideds.Add(divided))
                    sum += divided;
            }
        }

        return sum;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/rkzH6YsPNgoJjn75i">Link to challenge</see>
    /// </summary>
    public static string OverTime(double[] arr)
    {
        double startHourDouble = arr[0];
        double endHourDouble = arr[1];

        string normalizedStartHourString = string.Format("{00:00.00}", startHourDouble).Replace('.', ':');
        string normalizedEndHourString = string.Format("{00:00.00}", endHourDouble).Replace('.', ':');
        TimeOnly startHour = TimeOnly.Parse(normalizedStartHourString);
        TimeOnly endHour = TimeOnly.Parse(normalizedEndHourString);

        TimeSpan workingHour = TimeSpan.Zero;
        TimeSpan overTimeHour = TimeSpan.Zero;
        if (startHour.Hour >= 17)
            overTimeHour = endHour - startHour;
        else
        {
            if (endHour.Hour >= 17)
            {
                workingHour = new TimeOnly(17, 0) - startHour;
                overTimeHour = endHour - new TimeOnly(17, 0);
            }
            else
                workingHour = endHour - startHour;
        }

        var workingPayment = workingHour.TotalMinutes * (arr[2] / 60);
        var overtimePayment = overTimeHour.TotalMinutes * (arr[2] / 60) * arr[3];

        double totalPayment = workingPayment + overtimePayment;
        double roundedTotlaPayment = Math.Round(totalPayment, 2, MidpointRounding.AwayFromZero);
        return roundedTotlaPayment.ToString("C2");
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/6S2aJYTjAka94muDT">Link to challenge</see>
    /// </summary>
    public static int[] TrackRobot(string steps)
    {
        var point = new[] { 0, 0 };
        if (string.IsNullOrEmpty(steps))
        {
            return point;
        }

        var faces = new[] { "east", "north", "west", "south" };
        var faceIndex = 0;
        foreach (var step in steps)
        {
            if (step == '.')
                switch (faces[faceIndex])
                {
                    case "east":
                        point[0] += 1;
                        break;
                    case "west":
                        point[0] -= 1;
                        break;
                    case "north":
                        point[1] += 1;
                        break;
                    case "south":
                        point[1] -= 1;
                        break;
                }
            else
            {
                if (step == '<')
                    faceIndex = faceIndex == faces.Length - 1 ? 0 : faceIndex + 1;
                else if (step == '>')
                    faceIndex = faceIndex == 0 ? faces.Length - 1 : faceIndex - 1;

            }
        }
        return point;

    }
}