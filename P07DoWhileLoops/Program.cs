int a = 1; 
int b = 3;
int c = 41;
int d = 103;

bool loop = true;

void AskUserBetween(int min, int max)
{
    do
    {
        Console.WriteLine($"Gimme a number between {min} and {max}");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        if (number < min && number > max) ;
        Console.WriteLine($"You entered {number}.");
    } 
    while (loop);
    
} 

AskUserBetween(1, 3);
AskUserBetween(41, 103);