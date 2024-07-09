using System.Data;
using System.Globalization;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;

namespace EdabitChallenges;

public static class Medium
{
    /// <summary>
    /// <see href="https://edabit.com/challenge/XovEQex684EnTcZqA>Link to challenge</see>
    /// </summary>
    public static string Century(int year)
    {
        var firstTwo = year.ToString().Substring(0, 2);
        var century =  year.ToString().EndsWith("00") ? int.Parse(firstTwo) + "" : (int.Parse(firstTwo) + 1) + "";
        return century + "th century";
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/jxQTbif5fx7J8FeTT>Link to challenge</see>
    /// </summary>
    public static bool KToK(string n, int k)
    {
        return BigInteger.Pow(k, k).ToString() == n;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/ToMXLjWDLQqFua7Wh>Link to challenge</see>
    /// </summary>
    public static string NoYelling(string phrase)
    {
        if (phrase.EndsWith('?'))
            return phrase.TrimEnd('?') + "?";

        if (phrase.EndsWith('!'))
            return phrase.TrimEnd('!') + "!";

        return phrase;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/G4DQHo2YgDBAxBJH8>Link to challenge</see>
    /// </summary>
    public static int pentagonal(int num)
    {
        return 0; //todo
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/NRAbyiQP9ZNa4bDRT>Link to challenge</see>
    /// </summary>
    public static int MysteryFunc(int num)
    {
        var nums = num.ToString().Select(c => int.Parse(c.ToString())).ToArray();

        return nums.Aggregate((a, b) => a * b);
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/AyCKKtuhYjNo9eYwJ>Link to challenge</see>
    /// </summary>
    public static int LargestGap(int[] arr)
    {
        //var temp = arr.Order().Zip([arr.], (a, b) => 2);
        int maxGap = 0;
        arr = arr.Order().ToArray();
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int gap = arr[i + 1] - arr[i];
            if (gap > maxGap)
                maxGap = gap;
        }

        return maxGap;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/AyCKKtuhYjNo9eYwJ>Link to challenge</see>
    /// </summary>
    public static int LargestGap2(int[] arr)
    {
        var firstArr = arr.Order().ToArray();
        var secondArr = firstArr[1..^1].Append(firstArr[^1]).ToArray();
        var result = firstArr.Zip(secondArr, (a, b) => b - a).Max();
        return result;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/n5Q8vWopD3Kmc8ADi>Link to challenge</see>
    /// </summary>
    public static bool IsValidPhoneNumber(string str)
    {
        return Regex.IsMatch(str, @"^\([0-9]{3}\) [0-9]{3}-[0-9]{4}$");
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/uz6HACQLjH9DE6HcP>Link to challenge</see>
    /// </summary>
    public static decimal MyPi(int n)
    {
        return Math.Round(decimal.Parse(Math.PI.ToString("f6")), n, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/H77JNgLtEnQcX5hcu>Link to challenge</see>
    /// </summary>
    public static bool IsSymmetrical(int num)
    {
        return num.ToString() == string.Concat(num.ToString().Reverse());
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/5B4jvew2NvzKhfcQv>Link to challenge</see>
    /// </summary>
    public static bool CheckPerfect(int num)
    {
        List<int> factors = [];
        for (int i = 1; i <= num / 2; i++)
        {
            if (num % i == 0)
                factors.Add(i);
        }

        return factors.Sum() == num ? true : false;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/SfZx7qzXheYQxtQbF>Link to challenge</see>
    /// </summary>
    public static string RemoveSpecialCharacters(string str)
    {
        return string.Concat(str.Where(c => (char.IsLetterOrDigit(c) || c is '_' or '-' or ' ')));
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/ynZfn2LifKN25fP84>Link to challenge</see>
    /// </summary>
    public static string FindNemo(string sentence)
    {
        var firstIndex = sentence.Split(' ').ToList().IndexOf("Nemo");
        return firstIndex == -1 ? "I can't find Nemo :(" : $"I found Nemo at {firstIndex + 1}!";
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/biJhNvddqC5zmRuKz>Link to challenge</see>
    /// </summary>
    public static bool HasFriday13th(int month, int year)
    {
        return new DateTime(year, month, 13).DayOfWeek == DayOfWeek.Friday;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/7F8ZhHpxeW7K65XRL>Link to challenge</see>
    /// </summary>
    public static int SumSmallest(int[] values)
    {
        return values.Where(x => x >= 0).Order().Take(2).Sum();
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/8Sc582yHht2auBpCY">Link to challenge</see>
    /// </summary>
    public static bool IsStrangePair(string str1, string str2)
    {
        if (str1 == "" && str2 == "")
            return true;
        if (str1 == "" || str2 == "")
            return false;

        return str1[0] == str2[^1] && str1[^1] == str2[0];
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/nvphhA5K6Xhk7FScP">Link to challenge</see>
    /// </summary>
    public static byte[] GetUTF8BOM() => UTF8Encoding.UTF8.GetPreamble();


    /// <summary>
    /// <see href="https://edabit.com/challenge/GvGSPC9wiY4bS9AMg">Link to challenge</see>
    /// </summary>
    public static string FormatNum(int num)
    {
        return num.ToString("C0").Replace(CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol, "");
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/GvGSPC9wiY4bS9AMg">Link to challenge</see>
    /// </summary>
    public static string FormatNumV2(int num)
    {
        return num.ToString("n0");
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/4eSei6t8emzpyMwvu">Link to challenge</see>
    /// </summary>
    public static int[] FilterArray(object[] arr)
    {
        return arr.Where(x => x is int).Select(x => (int)x).ToArray();
    }

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
            return string.Concat(str.Substring(0, str.Length - 4).Select(x => "#")) + str.Substring(str.Length - 4);
        }
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/b5HL5ju3Fpx5zjoXn">Link to challenge</see>
    /// </summary>
    public static int Gcd(int n1, int n2)
    {
        //ToDo
        return 0;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/b5HL5ju3Fpx5zjoXn">Link to challenge</see>
    /// </summary>
    public static int Tetra(int n)
    {
        //ToDo
        return 0;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/zcuASzWmpFHpPtrbH">Link to challenge</see>
    /// </summary>
    public static string HighLow(string str)
    {
        var numbers = str.Split(" ").Select(int.Parse);
        return $"{numbers.Max()} {numbers.Min()}";
    }
}