using System.ComponentModel.Design;

void PrintWelcomeMessage(string firstName, string lastName){
    Console.WriteLine($"Welcome {firstName} {lastName}");
}
PrintWelcomeMessage("Marc", "Zaku");
PrintWelcomeMessage("James", "Bond");
PrintWelcomeMessage("Michael", "Jackson");

//P05_1

void Average(int a, int b)
{
    int average = a + b / 2;
    Console.WriteLine($"Average number is {average}");
}
Average(2, 6);
Average(0, 10);
Average(-12, 12);
Average(11, 9);

//P05_2

void PowerOf(int x, int y)
{
    int pow = (x * y) * y;
    Console.WriteLine($"Result: {pow}");
}

PowerOf(3, 2);
PowerOf(5, 1);
PowerOf(2, 5);
PowerOf(2, 10);
PowerOf(19, 0);
PowerOf(13, 1);

void numRandom(double min, double max)
{
    Random random = new Random();
    double randomNumber = random.NextDouble() * (max - min) + min;
    Console.WriteLine($"random number is {randomNumber}");
}
numRandom(3, 7);

//P05_3

void GetUserRandomNumber(int minimum, int maximum)
{
    Console.WriteLine($"Gimme a number between {minimum} and {maximum}");
    string userNumber = Console.ReadLine();
    int userInt = int.Parse(userNumber);
    {
        if (userInt >= minimum && userInt <= maximum) ;
        Console.WriteLine("Correct!");
    }
}
GetUserRandomNumber(1, 10);