int a = 1;
int b = 3;
int c = 41;
int d = 103;

    int askUserBetween(int min, int max);
    {
        do
        {
            Console.WriteLine("Gimme a number between {a} & {b}.");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            
            if (userNumber >= a && userNumber <= b) ;
            Console.WriteLine($"You gave me {userNumber}.");
        } while ();
    }

