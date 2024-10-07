//P04_1_1

    while (true)
    {
        Console.WriteLine("Would you like to buy a game?");
        if (Console.ReadLine() == ("yes"))
        {
            Console.WriteLine("Thank you.");
            return;
        }
    }

//P04_1_2
    
    void health(int hp){
        if(hp == 3){
            Console.WriteLine(hp--);
            health(hp);
            return;
        }
        health(5);
    }
    
    

    //P04_1_3
    void MagicMessage(){
        Console.WriteLine("You're trying to find the magic message.");
        goto Magic;
        return;
        Magic:
        Console.WriteLine("You found the magic message.");
    }
    MagicMessage();

//P04_2_1
    
        static void Main()
        {
            int four = 4;
            int five = 5;
            int sum = five + four;
            Console.WriteLine(sum);
        }

        static int four()
        {
            return 4;
        }

        static int five()
        {
            return 5;
        }
    //P04_2_2

    static void Main2()
    {
        int userMatches = GetUserMatches();
    }

    static int GetUserMatches()
    {
        int matches;
        while (true)
        {
            Console.WriteLine("What are your matches?");
            string match = Console.ReadLine();
            if (int.TryParse(match, out matches))
            {
                if (matches >= 1 && matches <= 3)
                {
                    return matches;
                }
            }
            Console.WriteLine("You did not enter a valid number. Please enter a valid number.");
        }
    }
    //P04_2_3

    static void Main3()
    {
        int AIMatches = GetAIMatches();
    }

    static int GetAIMatches()
    {
        Random random = new Random();
        return random.Next(1, 4);
    }