namespace EdabitChallenges;

public static class Expert
{
    /// <summary>
    /// <see href="https://edabit.com/challenge/uhsik73PY7Y2XftzG">Link to challenge</see>
    /// </summary>
    public static string TranslateWord(string word)
    {
        if (string.IsNullOrWhiteSpace(word))
            return "";

        string result = "";

        char[] vowels = { 'a', 'o', 'i', 'e', 'u' };
        int minIndex = -1;

        if (vowels.Contains(Char.ToLower(word[0])))
        {
            result = word + "yay";
        }
        else
        {
           var index = word.IndexOfAny(vowels); // 3
            result = word.Substring(index) + word[0..index] + "ay";
            if(char.IsUpper(word[0]))
            {
                result = char.ToUpper( result[0])+ result.Substring(1).ToLower();
            }
        }

        return result;
    }
}