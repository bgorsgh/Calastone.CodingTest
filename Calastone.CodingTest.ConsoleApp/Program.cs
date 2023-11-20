using Calastone.CodingTest.TextFilter;

Console.WriteLine("Please input a file path:");

var filePath = Console.ReadLine();

if (!File.Exists(filePath))
{
    Console.WriteLine("File not found: " + filePath);
    return;
}

var inputText = File.ReadAllText(filePath);

var filters = new List<IFilter>
{
    new MinimumLengthFilter(3),
    new CharacterFilter('t'),
    new VowelInMiddleFilter()
};

var textFilter = new TextFilter(filters);

var result = textFilter.Filter(inputText);

Console.WriteLine(result);