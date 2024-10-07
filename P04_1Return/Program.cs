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
    
    //P04.1 
    static void main5()
    {
        Myfunction();
    }
    static void Myfunction()
    {

    Console.WriteLine("What's your name?");
        string name = Console.ReadLine();
        if (name == "Jack") ;
        {
            Console.WriteLine("What's your age?");
            string age = Console.ReadLine();
            int ageInt = Convert.ToInt32(age);
            if (ageInt >= 18) ;
            {
                Console.WriteLine("Do you want to enter?");
                string enter = Console.ReadLine();
                if (enter == "yes") ;
                {
                    Console.WriteLine("Congrats! You made it!");
                }
            }
        }
    }
    
    //P04.2
    static void Main7()
    {
        PlayGame();
    }

   static void PlayGame()
    {
        while (true)
        {
            string PlayerChoice = getPlayerChoice();
            string AIChoice = getAIChoice();
            
            Console.WriteLine($"{PlayerChoice}");
            Console.WriteLine($"{AIChoice}");
            
            string result = whoWin(PlayerChoice, AIChoice);
            Console.WriteLine(result);
        }
    }

    static string getPlayerChoice()
    {
        string choice;
        while (true)
        {
            Console.WriteLine("Rock, Paper, or Scissors?");
            choice = Console.ReadLine();

            if (choice == "Rock" || choice == "Paper" || choice == "Scissors")
            {
                return choice;
            }
            Console.WriteLine("Try again.");
        }
    }

    static string getAIChoice()
    {
        Random random = new Random();
        int choice = random.Next(1, 3);
        switch (choice)
        {
            case 0: return "Rock";
            case 1: return "Paper";
            case 2: return "Scissors";
                return null;
        }

        return null;
    }


    static string whoWin(string Player, string AI)
    {
        if (Player.Equals(AI))
        {
            return "It's a tie";
        }

        if ((Player.Equals("Rock") && AI.Equals("Scissors")
             || Player.Equals("Paper") && AI.Equals("Rock") ||
             Player.Equals("Scissors") && AI.Equals("Paper")))
        {
            return "You wins";
        }
        return "AI wins";
    }

    
   