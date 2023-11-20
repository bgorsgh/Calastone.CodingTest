namespace Calastone.CodingTest.UnitTests;

public class FilterUnitTests
{
    [Fact]
    public void VowelFilter_SingleCentre_ReturnsTrue()
    {
        var input = "clean";
        var sut = new VowelInMiddleFilter();

        var result = sut.Filter(input);

        Assert.True(result);
    }

    [Fact]
    public void VowelFilter_DoubleCentre_ReturnsTrue()
    {
        var input = "clean";
        var sut = new VowelInMiddleFilter();

        var result = sut.Filter(input);

        Assert.True(result);
    }

    [Fact]
    public void VowelFilter_SingleCentre_ReturnsFalse()
    {
        var input = "the";
        var sut = new VowelInMiddleFilter();

        var result = sut.Filter(input);

        Assert.False(result);
    }

    [Fact]
    public void VowelFilter_DoubleCentre_ReturnsFalse()
    {
        var input = "rather";
        var sut = new VowelInMiddleFilter();

        var result = sut.Filter(input);

        Assert.False(result);
    }

    [Fact]
    public void VowelFilter_1LetterWord_ReturnsTrue()
    {
        var input = "a";
        var sut = new VowelInMiddleFilter();

        var result = sut.Filter(input);

        Assert.True(result);
    }

    [Fact]
    public void VowelFilter_1LetterWordUpperCase_ReturnsTrue()
    {
        var input = "I";
        var sut = new VowelInMiddleFilter();

        var result = sut.Filter(input);

        Assert.True(result);
    }

    [Fact]
    public void VowelFilter_1LetterWordUpperCase_ReturnsFalse()
    {
        var input = "X";
        var sut = new VowelInMiddleFilter();

        var result = sut.Filter(input);

        Assert.False(result);
    }

    [Fact]
    public void MinimumLengthFilter_UnderMinLength_ReturnsTrue()
    {
        var input = "I";
        var sut = new MinimumLengthFilter(2);

        var result = sut.Filter(input);

        Assert.True(result);
    }

    [Fact]
    public void MinimumLengthFilter_MinLength_ReturnsFalse()
    {
        var input = "ate";
        var sut = new MinimumLengthFilter(3);

        var result = sut.Filter(input);

        Assert.False(result);
    }

    [Fact]
    public void MinimumLengthFilter_OverMinLength_ReturnsFalse()
    {
        var input = "boat";
        var sut = new MinimumLengthFilter(3);

        var result = sut.Filter(input);

        Assert.False(result);
    }

    [Fact]
    public void CharacterFilter_ContainsCharacter_ReturnsTrue()
    {
        var input = "boat";
        var sut = new CharacterFilter('b');

        var result = sut.Filter(input);

        Assert.True(result);
    }

    [Fact]
    public void CharacterFilter_DoesNotContainCharacter_ReturnsFalse()
    {
        var input = "bloat";
        var sut = new CharacterFilter('p');

        var result = sut.Filter(input);

        Assert.False(result);
    }

    [Fact]
    public void CharacterFilter_ContainsUpperCaseCharacter_ReturnsFalse()
    {
        var input = "bloat";
        var sut = new CharacterFilter('A');

        var result = sut.Filter(input);

        Assert.False(result);
    }

    [Fact]
    public void CharacterFilter_ContainsUpperCaseCharacter_ReturnsTrue()
    {
        var input = "Bloat";
        var sut = new CharacterFilter('B');

        var result = sut.Filter(input);

        Assert.True(result);
    }

    [Fact]
    public void CharacterFilter_EmptyString_ReturnsFalse()
    {
        var input = string.Empty;
        var sut = new CharacterFilter('B');

        var result = sut.Filter(input);

        Assert.False(result);
    }

    [Fact]
    public void VowelFilter_EmptyString_ReturnsFalse()
    {
        var input = string.Empty;
        var sut = new VowelInMiddleFilter();

        var result = sut.Filter(input);

        Assert.False(result);
    }

    [Fact]
    public void LengthFilter_EmptyString_ReturnsFalse()
    {
        var input = string.Empty;
        var sut = new MinimumLengthFilter(0);

        var result = sut.Filter(input);

        Assert.False(result);
    }

    [Fact]
    public void LengthFilter_EmptyString_ReturnsTrue()
    {
        var input = string.Empty;
        var sut = new MinimumLengthFilter(1);

        var result = sut.Filter(input);

        Assert.True(result);
    }
}
