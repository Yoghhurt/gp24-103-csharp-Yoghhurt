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
    void healthBar()
    {
        int health = 100;
        healthDmg(health);
    }

    void healthDmg(int health)
    {
        Console.WriteLine($"Health: {health}");

        health--;

        if (health == 3)
        {
            return;
        } 
        healthBar();
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
