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

    