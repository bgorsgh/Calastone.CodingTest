namespace Calastone.CodingTest.TextFilter
{
    /// <summary>
    /// Interface for text filtering.
    /// </summary>
    public interface ITextFilter
    {
        /// <summary>
        /// Method to filter a given text input.
        /// </summary>
        /// <param name="input">The text to be filtered.</param>
        /// <returns>The filtered output.</returns>
        string Filter(string input);
    }
}