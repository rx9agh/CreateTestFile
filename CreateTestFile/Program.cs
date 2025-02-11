
string fileName = "test.txt";
int countOfLines = 1000_000;

string[] stringPartOfLines = [ "Apple test", "Carrot", "Banana", "Orange", "Grapes", 
"Pineapple", "Watermelon", "Strawberry", "Blueberry", "Potato" ];

if(args.Length > 0 && args[0] != string.Empty && int.TryParse(args[0], out int lines))
    countOfLines = lines;

using StreamWriter writer = new(fileName, false);
var rand = new Random();
List<int> randomNumbers = [.. Enumerable.Range(1, countOfLines).OrderBy(i => rand.Next())];

int count = 1;
foreach (int numberPartOfLine in randomNumbers)
{
    int rn = rand.Next(0, stringPartOfLines.Length - 1);
    await writer.WriteLineAsync($"{numberPartOfLine}. {stringPartOfLines[rn]}");

    if(count%10000 == 0)
        Console.Write("|");
    count++;
}
