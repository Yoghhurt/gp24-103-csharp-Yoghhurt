//P02_1

{
    static void HelloWorld()

    {
        Console.WriteLine("Hello World!");
    }

    static void Main()
    {
        HelloWorld();
    }
}

//P02_2
{
    static void AskForHelp()
    {
        Console.WriteLine("Asking for help!");
        IAmTheHelp();
    }
static void IAmTheHelp()
    {
        Console.WriteLine("I am the help!");
    }
    static void Main()
    {
        AskForHelp();
    }
}
//P02_3
{
    
    static void GenerateRandomNumber()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101); 
        Console.WriteLine(randomNumber); 
    }

    static void Main()
    {
        
        Console.WriteLine("Generating random numbers between 1 and 100:");
        for (int i = 0; i < 5; i++)
        {
            GenerateRandomNumber();
        }
    }
}

//P02 Final

{
    
    static void MoveForward(int steps)
    {
        for (int i = 0; i < steps; i++)
        {
            Console.WriteLine("Move Forward.");
        }
    }

    
    static void TurnRight()
    {
        Console.WriteLine("Turn Right.");
    }

    
    static void TurnLeft()
    {
        Console.WriteLine("Turn Right."); 
        TurnRight();
        TurnRight();
    }

    static void Main()
    {
        
        MoveForward(3);
        
        
        TurnRight();
        TurnRight();
        MoveForward(3);
        
        
        TurnLeft();
        MoveForward(3);
        
        
        TurnLeft();
        MoveForward(1);
        
        
        TurnRight();
        TurnRight();
        MoveForward(1);
    }
}


