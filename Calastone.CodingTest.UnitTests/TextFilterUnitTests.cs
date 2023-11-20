namespace Calastone.CodingTest.UnitTests;

public class TextFilterUnitTests
{
    [Fact]
    public void TextFilter_NoFilters_ReturnsInput()
    {
        var sut = new TextFilter.TextFilter(new List<IFilter>());
        var input = "clean what currently the rather";

        var result = sut.Filter(input);

        Assert.Equal("clean what currently the rather", result);
    }

    [Fact]
    public void TextFilter_VowelFilter_FiltersCorrectly()
    {
        var filters = new List<IFilter>
        {
            new VowelInMiddleFilter()
        };
        var sut = new TextFilter.TextFilter(filters);
        var input = "clean what currently the rather";

        var result = sut.Filter(input);

        Assert.Equal("the rather", result);
    }

    [Fact]
    public void TextFilter_LengthFilter_FiltersCorrectly()
    {
        var filters = new List<IFilter>
        {
            new MinimumLengthFilter(4)
        };
        var sut = new TextFilter.TextFilter(filters);
        var input = "clean what currently the rather";

        var result = sut.Filter(input);

        Assert.Equal("clean what currently rather", result);
    }

    [Fact]
    public void TextFilter_CharacterFilter_FiltersCorrectly()
    {
        var filters = new List<IFilter>
        {
            new CharacterFilter('t')
        };
        var sut = new TextFilter.TextFilter(filters);
        var input = "clean what currently the rather";

        var result = sut.Filter(input);

        Assert.Equal("clean", result);
    }

    [Fact]
    public void TextFilter_CharacterLengthVowelFilters_FiltersCorrectly()
    {
        var filters = new List<IFilter>
        {
            new CharacterFilter('t'),
            new MinimumLengthFilter(4),
            new VowelInMiddleFilter()
        };
        var sut = new TextFilter.TextFilter(filters);
        var input = "The quick brown fox jumped over the lazy dog.";

        var result = sut.Filter(input);

        Assert.Equal("jumped", result);
    }

    [Fact]
    public void TextFilter_LengthAndVowelFiltersWithPunctuation_FiltersCorrectly()
    {
        var filters = new List<IFilter>
        {
            new MinimumLengthFilter(4),
            new VowelInMiddleFilter()
        };
        var sut = new TextFilter.TextFilter(filters);
        var input = "This should return correctly, taking account of punctuation, which is not returned in the output...";

        var result = sut.Filter(input);

        Assert.Equal("output", result);
    }

    [Fact]
    public void TextFilter_LengthFilterWithApostrophe_FiltersCorrectly()
    {
        var filters = new List<IFilter>
        {
            new MinimumLengthFilter(5)
        };
        var sut = new TextFilter.TextFilter(filters);
        var input = "Isn't is a four letter word.";

        var result = sut.Filter(input);

        Assert.Equal("letter", result);
    }

    [Fact]
    public void TextFilter_VowelFilterWithApostrophe_FiltersCorrectly()
    {
        var filters = new List<IFilter>
        {
            new VowelInMiddleFilter()
        };
        var sut = new TextFilter.TextFilter(filters);
        var input = "Isn't is a four letter word.";

        var result = sut.Filter(input);

        Assert.Equal("Isn't letter", result);
    }

    [Fact]
    public void TextFilter_ChracterFilterWithApostrophe_FiltersCorrectly()
    {
        var filters = new List<IFilter>
        {
            new CharacterFilter('t')
        };
        var sut = new TextFilter.TextFilter(filters);
        var input = "Isn't is a four letter word.";

        var result = sut.Filter(input);

        Assert.Equal("is a four word", result);
    }
}