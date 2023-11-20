using System.Text.RegularExpressions;

namespace Calastone.CodingTest.TextFilter;

/// <inheritdoc cref="IFilter"/>
/// <remarks>
/// <see cref="IFilter"/> implementation that filters out words with a vowel in the middle character or middle two characters. Removes non-word characters before applying the rule.
/// </remarks>
public class VowelInMiddleFilter : IFilter
{
    private const string RegexPattern = "[aeiouAEIOU]";

    /// <inheritdoc/>
    public bool Filter(string word)
    {
        word = Regex.Replace(word, @"[^\p{L}]", string.Empty);

        if (word.Length == 0)
            return false;

        var middleIndex = word.Length / 2;

        var middleLetters = word.Length % 2 == 0
            ? word.Substring(middleIndex - 1, 2)
            : word.Substring(middleIndex, 1);

        return Regex.IsMatch(middleLetters, RegexPattern);
    }
}
