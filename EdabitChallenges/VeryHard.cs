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
}