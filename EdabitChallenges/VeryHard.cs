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
}