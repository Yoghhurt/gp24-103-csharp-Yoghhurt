void Paint()
{
    
    char[,] canvas = new char[5, 5];

    
    for (int i = 0; i < canvas.GetLength(0); i++)
    {
        for (int j = 0; j < canvas.GetLength(1); j++)
        {
            canvas[i, j] = ' ';
        }
    }

    while (true)
    {
        
        Console.WriteLine("Current canvas:");
        for (int i = 0; i < canvas.GetLength(0); i++)
        {
            for (int j = 0; j < canvas.GetLength(1); j++)
            {
                Console.Write($"[{i},{j}]: {canvas[i, j]}  ");
            }
            Console.WriteLine();
        }

        
        Console.Write("Enter x coordinate (0-4): ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Enter y coordinate (0-4): ");
        int y = int.Parse(Console.ReadLine());

        
        if (x < 0 || x >= 5 || y < 0 || y >= 5)
        {
            Console.WriteLine("Invalid coordinates. Please try again.");
            continue;
        }

        
        Console.Write("Enter a symbol to store: ");
        char symbol = Console.ReadLine()[0];

        
        canvas[y, x] = symbol;
    }
}
Paint();