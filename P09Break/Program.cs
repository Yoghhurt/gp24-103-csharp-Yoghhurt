for (int i = 10; i <= 0; i--)
{
    Console.WriteLine($"{i}");
    string userInput = Console.ReadLine();
    int userInputInt = int.Parse(userInput);
    int outcome = i - userInputInt;
    Console.WriteLine(outcome);
    {
        if (userInput == "Stop") ;
        Console.WriteLine("The game has ended");
        break; 
    }
    

}