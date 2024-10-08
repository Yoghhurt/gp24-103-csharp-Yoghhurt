int matches = 10;
while (matches > 0)
{
    Console.WriteLine($"There are {matches} matches left.");
    Console.WriteLine($"How many matches would you like to draw?");
    string input = Console.ReadLine();
    int userMatches = int.Parse(input);
    matches -= userMatches;
}
Console.WriteLine("Game Over");