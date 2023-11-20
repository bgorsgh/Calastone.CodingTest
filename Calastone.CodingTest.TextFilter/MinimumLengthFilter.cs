using System.Text.RegularExpressions;

namespace Calastone.CodingTest.TextFilter;

/// <inheritdoc cref="IFilter"/>
/// <remarks>
/// <see cref="IFilter"/> implementation that filters out words with a length under a specified minimum. Removes non-word characters before applying the rule.
/// </remarks>
public class MinimumLengthFilter : IFilter
{
    private readonly int _minLength;

    /// <summary>
    /// Initializes a new instance that will filter out words under the minimum length provided.
    /// </summary>
    /// <param name="minLength">The minimum length of words that will pass the filter.</param>
    public MinimumLengthFilter(int minLength) => _minLength = minLength;

    /// <inheritdoc/>
    public bool Filter(string word) => Regex.Replace(word, @"[^\p{L}]", string.Empty).Length < _minLength;
}
