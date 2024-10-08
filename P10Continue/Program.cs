﻿void game()
{
    int health = 10;
    Console.WriteLine($"You start with {health} Health.");

    while (health > 0)
    {
        Console.Write($"You have {health} Health. Enter a number or type 'Quit' to end the game: ");
        string input = Console.ReadLine();

        
        if (input.Equals("Quit", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Game Finished.");
            break;
        }
        
        if (int.TryParse(input, out int change))
        {
            health -= change; 
            Console.WriteLine($"Your new health is {health}.");
        }
        else
        {
            Console.WriteLine("Invalid input. Turn skipped.");
        }
        
        if (health <= 0)
        {
            Console.WriteLine("You have no health left! Game Over.");
            Console.WriteLine("Game Finished.");
        }
    }
}
game();

//skip

for(int i = 0;;i++){
    // -----------------------
    // only add code in between here...
    if (i % 2 == 0)
    {
        continue;
    }

    if (i % 5 == 0)
    {
        continue;
    }

    if (i >= 13)
    {
        break;
    }
    // ...and here
    // -----------------------
    Console.WriteLine(i);
}
Console.WriteLine("Done.");