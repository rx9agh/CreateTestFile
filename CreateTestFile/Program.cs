
string fileName = "test.txt";
int countOfLines = 1000_000;

string[] strings = [ "Apple test", "Carrot", "Banana", "Orange", "Grapes", 
"Pineapple", "Watermelon", "Strawberry", "Blueberry", "Potato" ];

if(args.Length > 0 && args[0] != string.Empty && int.TryParse(args[0], out int val))
    countOfLines = val;

using StreamWriter writer = new(fileName, false);
var rand = new Random();
List<int> listNumbers = [.. Enumerable.Range(1, countOfLines).OrderBy(i => rand.Next())];

foreach (int number in listNumbers)
{
    int rn = rand.Next(0, strings.Length - 1);
    await writer.WriteLineAsync($"{number}. {strings[rn]}");
}
