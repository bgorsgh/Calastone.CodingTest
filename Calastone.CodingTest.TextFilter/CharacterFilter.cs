namespace Calastone.CodingTest.TextFilter;

/// <inheritdoc cref="IFilter"/>
/// <remarks>
/// <see cref="IFilter"/> implementation that filters out words containing a specified character.
/// </remarks>
public class CharacterFilter : IFilter
{
    private readonly char _character;

    /// <summary>
    /// Initializes a new instance that will filter out words with the character provided.
    /// </summary>
    /// <param name="character">The character to filter on.</param>
    public CharacterFilter(char character) => _character = character;

    /// <inheritdoc/>
    public bool Filter(string word) => word.Contains(_character);
}
