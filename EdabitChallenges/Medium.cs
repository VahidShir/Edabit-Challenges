using System.Reflection.Metadata.Ecma335;

namespace EdabitChallenges;

public static class Medium
{
    /// <summary>
    /// <see href="https://edabit.com/challenge/2QvnWexKoLfcJkSsc">Link to challenge</see>
    /// </summary>
    public static int[] ArrayOfMultiples(int num, int length)
    {
        int[] reult = new int[length];

        for (int i = 0; i < length; i++)
        {
            reult[i] = num * (i + 1);
        }

        return reult;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/2QvnWexKoLfcJkSsc">Link to challenge</see>
    /// </summary>
    public static int[] ArrayOfMultiplesV2(int num, int length)
        => Enumerable.Range(1, length).Select(x => x * num).ToArray();

    /// <summary>
    /// <see href="https://edabit.com/challenge/99oN5igrbXddAjHEL">Link to challenge</see>
    /// </summary>
    public static string ReverseCase(string input)
    {
        return string.Concat(input.Select(c => char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c)));
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/Q7g8sfg7DJq6CyMMu">Link to challenge</see>
    /// </summary>
    public static bool CheckEquality(object a, object b)
    {
        return Object.Equals(a, b);
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/6qFnpAhd3kdmYcNG2">Link to challenge</see>
    /// </summary>
    public static int[] IndexOfCapitals(string text)
    {
        var temp = text.Select((v, index) =>
        {
            if (char.IsUpper(v))
                return index;
            else
                return -1;
        });

        return temp.Where(x => x != -1).ToArray();
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/JYEufqRvkusjr5R58">Link to challenge</see>
    /// </summary>
    public static string Bomb(string text) =>
        text.Contains("bomb", StringComparison.InvariantCultureIgnoreCase) ?
            "Duck!!!" : "There is no bomb, relax.";

    /// <summary>
    /// <see href="https://edabit.com/challenge/hqTYj7NbLnCcjxryi">Link to challenge</see>
    /// </summary>
    public static string[] ParseArray(object[] arr)
    {
        return arr.Select(x => x.ToString()).ToArray();
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/nermqxzovZbfFBC9X">Link to challenge</see>
    /// </summary>
    public static double[] FindLargest(double[][] values)
    {
        return values.Select(x => x.Max()).ToArray();
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/ZSvj2W3J6QRydkyh2">Link to challenge</see>
    /// </summary>
    public static string CountAll(string txt)
    {
        return (new { LETTERS = txt.Count(char.IsLetter), DIGITS = txt.Count(char.IsDigit) }).ToString();
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/F6m5ZRyzK5fmqTrBG">Link to challenge</see>
    /// </summary>
    public static int Collatz(int num)
    {

        int steps = 0;

        while (num != 1)
        {
            if (num % 2 == 0)
            {
                num /= 2;
            }
            else
            {
                num = num * 3 + 1;
            }

            steps++;
        }

        return steps;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/zaokQWNdEudmFWpk7">Link to challenge</see>
    /// </summary>
    public static int CounterpartCharCode(char symbol)
    {
        return char.IsLower(symbol) ? char.ToUpper(symbol) : char.ToLower(symbol);
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/zn3A3AAzoE7vezw7Q">Link to challenge</see>
    /// </summary>
    public static int CountOnes(int i)
    {
        return Convert.ToString(i, 2).Count(x => x == '1');
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/SXeEZPxDM9Y5HzLvw">Link to challenge</see>
    /// </summary>
    public static int[] CountPosSumNeg(double[] arr)
    {
        if (arr.Length == 0)
            return [];

        return [arr.Count(i => i > 0), (int)arr.Where(i => i < 0).Sum()];
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/gBYEFXeD9G2JMZ9dD">Link to challenge</see>
    /// </summary>
    public static bool ValidatePIN(string pin)
    {
        if (pin.Length is not 4 and not 6)
            return false;

        return pin.All(char.IsDigit);
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/JF25KTZEcPzXhBvpM">Link to challenge</see>
    /// </summary>
    public static string GetMiddle(string str)
    {
        int length = str.Length;

        if (length % 2 == 0)
        {
            return $"{str[length / 2 - 1]}{str[length / 2]}";
        }
        else
        {
            return str[length / 2].ToString();
        }
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/oedhscMcJBsD4fMo3">Link to challenge</see>
    /// </summary>
    public static int square_areas_difference(int radius)
    {
        //ToDo
        return 0;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/RFeBL2TzSf7mRMNJi">Link to challenge</see>
    /// </summary>
    public static string Maskify(string str)
    {
        if (str.Length < 5)
        {
            return str;
        }
        else
        {
            return $"{string.Concat(Enumerable.Repeat("#", str.Length - 4))}{string.Concat(str.Take(^4..))}";
        }
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/RFeBL2TzSf7mRMNJi">Link to challenge</see>
    /// </summary>
    public static string MaskifyV2(string str)
    {
        if (str.Length < 5)
        {
            return str;
        }
        else
        {
            return string.Concat(str.Substring(0, str.Length - 4).Select( x => "#")) + str.Substring(str.Length - 4);
        }
    }
}