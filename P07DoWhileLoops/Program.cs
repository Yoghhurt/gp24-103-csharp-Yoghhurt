using System.ComponentModel.Design;

int number;
int a = 1;
int b = 3;
int x = 41;
int y = 103;


int AskUserBetween(int min, int max)
{
    do
    {
        Console.WriteLine($"Gimme a number between {min} and {max}");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        min = a;
        max = b;
        if (number >= min && number <= max) ;
        Console.WriteLine($"You entered {number}.");
    } while (number < a && number > b);

    do
    {
        Console.WriteLine($"Gimme a number between {min} and {max}");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        min = x;
        max = y;
        if (number >= min && number <= max) ;
        Console.WriteLine($"You entered {number}.");
    } while (number < a && number > b);
    
} 