using System.Globalization;

namespace EdabitChallenges;

public static class Hard
{
        /// <summary>
    /// <see href="https://edabit.com/challenge/GvGSPC9wiY4bS9AMg">Link to challenge</see>
    /// </summary>
    public static string FormatNum(int num)
    {
        return string.Format("c2", num);
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/R4YcSt798Krokao2R">Link to challenge</see>
    /// </summary>
    public static string ConvertToHex(string inputword)
    {
        // ConvertToHex("hello world") ➞ "68 65 6c 6c 6f 20 77 6f 72 6c 64"
        return string.Join(" ", inputword.Select(c => Convert.ToHexString([(byte)c]))).ToLower();
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/YGhgctqPsKQxQQCFS">Link to challenge</see>
    /// </summary>
    public static string ReverseAndNot(int n)
    {
        return string.Concat((n.ToString()).Reverse()) + n.ToString();
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/wunaXvZw3WctYioeC">Link to challenge</see>
    /// </summary>
    public static string Uncensor(string censoredText, string vowels)
    {
        int counter = 0;
        string result = "";
        foreach (var c in censoredText)
        {
            if (c == '*')
            {
                result += vowels[counter];
                counter++;
            }
            else
            {
                result += c;
            }
        }

        return result;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/wunaXvZw3WctYioeC">Link to challenge</see>
    /// </summary>
    public static string UncensorV2(string censoredText, string vowels)
    {
        char[] result = censoredText.ToArray();

        foreach (var c in vowels)
        {
            result[string.Concat(result).IndexOf("*")] = c;
        }

        return string.Concat(result);
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/wunaXvZw3WctYioeC">Link to challenge</see>
    /// </summary>
    public static string UncensorV3(string censoredText, string vowels)
    {
        Queue<char> vowelsQueue = new Queue<char>(vowels.ToArray());

        return censoredText.Select(c => c == '*' ? vowelsQueue.Dequeue() : c).ConcatToString();
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/dZeNE4BJhyNgA99Fq">Link to challenge</see>
    /// </summary>
    public static string Interview(int[] times, int total)
    {
        string disqualified = "disqualified";

        //Interview(new int [] { 5, 5, 10, 10, 15, 15, 20, 20 }, 120) ➞ "qualified"
        if (total > 120)
            return disqualified;

        var timeLimit = new[] { 5, 5, 10, 10, 15, 15, 20, 20 };
        if (times.Length < timeLimit.Length)
            return disqualified;

        var passedTimes = timeLimit.Select((v, index) => times[index] <= v);
        //var exceededLimits = times.Zip(timeLimit, (a, b) => a > b);// it is another method
        if (passedTimes.Any(x => x == false))
            return disqualified;

        return "qualified";
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/SkY5Nw3rS7WvkQmFc">Link to challenge</see>
    /// </summary>
    public static bool IsSmooth(string sentence)
    {
        // "Carlos swam masterfully"
        var words = sentence.ToLower().Split(" ");
        var result = words.Select((item, index) => index == words.Length - 1 ? true :
            item.EndsWith(words[index + 1][0]) ? true : false).All(x => x);

        return result;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/SkY5Nw3rS7WvkQmFc">Link to challenge</see>
    /// </summary>
    public static bool IsSmoothV2(string sentence)
    {
        // "Carlos swam masterfully"
        var words = sentence.ToLower().Split(" ");

        for (var i = 0; i < words.Length - 1; i++)
        {
            if (words[i][^1] != words[i + 1][0])
                return false;
        }

        return true;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/SkY5Nw3rS7WvkQmFc">Link to challenge</see>
    /// </summary>
    public static bool IsSmoothV3(string sentence)
    {
        // "Carlos swam masterfully"
        var words = sentence.ToLower().Split(" ");

        var result = words.Where((item, index) =>
                    index != words.Length - 1 && item.EndsWith(words[index + 1][0])).Count() == words.Length - 1;


        return result;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/SkY5Nw3rS7WvkQmFc">Link to challenge</see>
    /// </summary>
    public static bool IsSmoothV4(string sentence)
    {
        // "Carlos swam masterfully"

        string normalizedSentence = sentence.ToLower();

        int[] FindAllIndexOf(string s, char c)
        {
            return s.Select((b, i) => b == c ? i : -1).Where(i => i != -1).ToArray();
        }

        int[] spaceIndices = FindAllIndexOf(normalizedSentence, ' ');

        foreach (var index in spaceIndices)
        {
            if (normalizedSentence[index - 1] != normalizedSentence[index + 1])
                return false;
        }

        return true;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/8tyXtHqAT3LAuHMqu">Link to challenge</see>
    /// </summary>
    public static bool IsValidHexCode(string sentence)
    {
        if (sentence[0] != '#')
            return false;

        try
        {
            Convert.FromHexString(sentence.Substring(1));

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/McGCFZYn8ikn3GSqz">Link to challenge</see>
    /// </summary>
    public static int PowerRanger(int power, int min, int max)
    {
        int counter = 0;
        var x = Math.Pow(min, 1.0 / power);
        while (Math.Pow(x, power) <= max)
        {
            counter++;
            x++;
        }

        return counter;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/McGCFZYn8ikn3GSqz">Link to challenge</see>
    /// </summary>
    public static int PowerRangerV2(int power, int min, int max)
    {
        int counter = 0;
        int num = 0;

        while (true)
        {
            var powered = (int)Math.Pow(counter, power);

            if (powered >= min && powered <= max)
            {
                num++;
            }
            else if (powered > max)
            {
                return num;
            }

            counter++;
        }
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/E4eAyJLjgGssf7GFJ">Link to challenge</see>
    /// </summary>
    public static int[] ProductEqualTarget(int[] arr, int target)
    {
        int power = 1;
        int[] result = new int[arr.Length];
        while (target > 1)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (target % arr[i] == 0)
                {
                    result[i] = power;
                    target /= arr[i];
                }
            }
            power++;
        }

        return result;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/E4eAyJLjgGssf7GFJ">Link to challenge</see>
    /// </summary>
    public static int[] ProductEqualTargetV2(int[] arr, int target)
    {
        int[] result = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            int power = 0;

            while (target % arr[i] == 0)
            {
                target = target / arr[i];
                power++;
            }

            result[i] = power;
        }

        return result;
    }


    /// <summary>
    /// <see href="https://edabit.com/challenge/y4esBva2cYph5QKg5">Link to challenge</see>
    /// </summary>
    public static string WeekAfter(string date)
    {
        return DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture).AddDays(7).ToString("dd/MM/yyyy");

    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/wXCzoLtvvEEYBs3p9">Link to challenge</see>
    /// </summary>
    public static int DuplicateCount(string str)
    {
        return str.GroupBy(c => c).Select(c => c.Count()).Count(c => c > 1);
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/wXCzoLtvvEEYBs3p9">Link to challenge</see>
    /// </summary>
    public static int DuplicateCount2(string str)
    {
        return str.CountBy(x => x).Count(c => c.Value > 1);
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/TAZywz6R2hu9tDQWc">Link to challenge</see>
    /// </summary>
    public static bool Cons(int[] arr)
    {
        var sorted = arr.Order().ToArray();
        return sorted[^1] - sorted[0] == sorted.Length - 1;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/X3btpQQEBeezX4jhK">Link to challenge</see>
    /// </summary>
    public static string CupSwapping(string[] swaps)
    {
        //cupSwapping(["AB", "CA", "AB"]) ➞ "C"
        var lastPosition = "B";
        foreach (var sw in swaps)
        {
            if (sw.Contains(lastPosition))
                lastPosition = sw.Replace(lastPosition, string.Empty);
        }
        return lastPosition;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/X3btpQQEBeezX4jhK">Link to challenge</see>
    /// </summary>
    public static string CupSwapping2(string[] swaps)
    {

        char position = 'B';

        foreach (var item in swaps)
        {
            if (item.ToUpper().Contains(position))
            {
                //setting new position
                position = char.ToUpper(item.First(c => c != position));
            }
        }

        return position.ToString();
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/g88PKZrCY6sWPBva7">Link to challenge</see>
    /// </summary>
    public static int[] TrackRobot(string[] instructions)
    {
        //{ "right 10", "up 50", "left 30", "down 10" }
        int x = 0, y = 0;
        foreach (var instruction in instructions)
        {
            var arrow = instruction.Split(" ")[0];
            var distance = int.Parse(instruction.Split(" ")[1]);

            switch (arrow)
            {
                case "right":
                    x += distance;
                    break;
                case "left":
                    x -= distance;
                    break;
                case "up":
                    y += distance;
                    break;
                case "down":
                    y -= distance;
                    break;
            };
        }
        return [x, y];
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/Bos7jCrynkgG9dAJ5">Link to challenge</see>
    /// </summary>
    public static string Collatz(Int64 a, Int64 b)
    {
        //If even: divide by 2.
        //If odd: multiply by 3, then add 1.
        return GetSteps(a) < GetSteps(b) ? "a" : "b";

        int GetSteps(long x)
        {
            if (x == 1)
                return 0;
            return GetSteps(x % 2 == 0 ? x / 2 : x * 3 + 1) + 1;
        }
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/t6R99zCQ7nesR7Rdk">Link to challenge</see>
    /// </summary>
    public static bool AlmostPalindrome(string str)
    {
        int diff = 0;
        for (int i = 0; i < str.Length / 2; i++)
        {
            if (str[i] != str[^(i + 1)])
            {
                diff++;
                if (diff > 1)
                {
                    return false;
                }
            }
        }
        return diff == 1 ? true : false;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/t6R99zCQ7nesR7Rdk">Link to challenge</see>
    /// </summary>
    public static bool AlmostPalindromeV2(string str)
    {
        string p = string.Concat(str.Reverse());

        return str.Select((c, i) => c == p[i]).Count(b => b) == str.Length - 2 ? true : false;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/t6R99zCQ7nesR7Rdk">Link to challenge</see>
    /// </summary>
    public static bool AlmostPalindromeV3(string str)
    {
        //abccia
        //aiccba
        string reverseStr = string.Concat(str.Reverse());

        var diffCount = str.Zip(reverseStr, (first, second) => first != second).Count(diff => diff == true);
        return diffCount == 2 ? true : false;
    }

    /// <summary>
    /// <see href="https://edabit.com/challenge/bqveyPRgcWZM7XzMQ">Link to challenge</see>
    /// </summary>
    public static string MysteryFunc(string str)
    {
        IEnumerable<string> result = str.Select((c, index) => index % 2 == 0 ? new string(c, int.Parse(str[index + 1].ToString())) : "");
        return string.Concat(result);
    }
}