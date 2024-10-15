class NimGame
{
    private int[] piles;

    public NimGame(int[] initialPiles)
    {
        piles = initialPiles;
    }

    public void DisplayPiles()
    {
        for (int i = 0; i < piles.Length; i++)
        {
            Console.WriteLine($"Row {i + 1}: {new string('O', piles[i])}");
        }
    }

    public bool IsGameOver()
    {
        foreach (var pile in piles)
        {
            if (pile > 0) return false;
        }
        return true;
    }

    public void PlayerTurn()
    {
        while (true)
        {
            DisplayPiles();
            Console.Write("Choose a row (1-3): ");
            int row = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("How many matches to draw (1-3): ");
            int matches = Convert.ToInt32(Console.ReadLine());

            if (row >= 0 && row < piles.Length && matches >= 1 && matches <= Math.Min(3, piles[row]))
            {
                piles[row] -= matches;
                break;
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
            }
        }
    }

    public void AiTurn()
    {
        Console.WriteLine("AI's turn:");
        Random rand = new Random();
        int row;
        do
        {
            row = rand.Next(0, piles.Length);
        } while (piles[row] == 0);

        int matches = rand.Next(1, Math.Min(3, piles[row]) + 1);
        piles[row] -= matches;
        Console.WriteLine($"AI drew {matches} from row {row + 1}.");
    }

    public void Play()
    {
        Console.WriteLine("Welcome to Nim!");
        while (!IsGameOver())
        {
            PlayerTurn();
            if (IsGameOver())
            {
                Console.WriteLine("You drew the last match! You lose!");
                break;
            }
            AiTurn();
            if (IsGameOver())
            {
                Console.WriteLine("AI drew the last match! You win!");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] initialPiles = { 3, 4, 5 }; // Starting configuration
        NimGame game = new NimGame(initialPiles);
        game.Play();
    }
}
