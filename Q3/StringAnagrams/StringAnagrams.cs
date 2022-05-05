namespace StringAnagrams;
public class StringAnagrams
{
    /// <summary>
    /// Method is used to determine if two strings are anagrams.
    /// Time and complexity should be O(n).
    /// </summary>
    /// <param name="firstStr"></param>
    /// <param name="secondStr"></param>
    /// <returns></returns>
    public bool AreAnagrams(string firstStr, string secondStr)
    {
        var filteredFirstStr = FormatAnagramString(firstStr);
        var filteredSecondStr = FormatAnagramString(secondStr);

        if (filteredFirstStr.Length != filteredSecondStr.Length)
        {
            return false;
        }

        var occurencesFirstStr = GetCharOccurences(filteredFirstStr);
        var occurencesSecondStr = GetCharOccurences(filteredSecondStr);

        foreach (var entry in occurencesFirstStr)
        {
            if (!occurencesSecondStr.ContainsKey(entry.Key))
            {
                return false;
            }
            if (occurencesSecondStr[entry.Key] != entry.Value)
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    /// Method is used to turn the input string into lowercase,
    /// remove all whitespace, and remove all punctuations.
    /// Time complexity should be O(n) since internally the functions iterate
    /// over n elements in input. Space complexity also, since we are creating
    /// a new string of size n-chars.
    /// </summary>
    /// <param name="input">Any kind of string.</param>
    /// <returns>Filtered string.</returns>
    private string FormatAnagramString(string input)
    {
        var lower = input.ToLower();

        var withoutWhitespace 
            = string.Concat(lower.Where(c => !Char.IsWhiteSpace(c)));

        var withoutPunct 
            = string.Concat(withoutWhitespace.Where(c => !Char.IsPunctuation(c)));

        return withoutPunct;
    }

    /// <summary>
    /// Method is used to create a hashtable with every unique characer in the input string,
    /// and the number of times the character occurs.
    /// Time and space complexity worst case O(n) if no recurring chars in input.
    /// </summary>
    /// <param name="input"></param>
    /// <returns>Hashset of unique characters.</returns>
    private Dictionary<char, int> GetCharOccurences(string input)
    {
        var charOccurences = new Dictionary<char, int>();

        foreach (var character in input)
        {
            if (!charOccurences.ContainsKey(character))
            {
                charOccurences.Add(character, 1);
            }
            else
            {
                charOccurences[character]++;
            }
        }

        return charOccurences;
    }
}
