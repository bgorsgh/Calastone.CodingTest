using System.Text.RegularExpressions;

namespace Calastone.CodingTest.TextFilter;

/// <inheritdoc cref="ITextFilter"/>
/// <remarks>
/// Text filter that applies filters to text. The input is split into words.
/// </remarks>
public class TextFilter : ITextFilter
{
    private readonly IList<IFilter> _filters;

    /// <summary>
    /// Initializes a new instance that will apply the filters provided.
    /// </summary>
    /// <param name="filters">List of <see cref="IFilter"/> to be applied.</param>
    public TextFilter(IList<IFilter> filters) => _filters = filters;

    /// <inheritdoc/>
    public string Filter(string input)
    {
        var words = Regex.Split(input, @"[^\p{L}']+");

        var output = words.Where(w => ApplyFilters(w));

        return string.Join(" ", output);
    }

    private bool ApplyFilters(string word)
    {
        if (word.Length == 0)
            return false;

        foreach (var filter in _filters)
        {
            if (filter.Filter(word))
                return false;
        }
        return true;
    }
}