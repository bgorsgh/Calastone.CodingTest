namespace Calastone.CodingTest.TextFilter;

/// <summary>
/// Filter interface with one method that returns a boolean indicating if the word should be filtered.
/// </summary>
public interface IFilter
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="word">The word to be filtered.</param>
    /// <returns>True if the word shoud be filtered, otherwise false.</returns>
    bool Filter(string word);
}
