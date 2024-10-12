void RandomCounts()
{
    int[] counts = new int[11];
    
    Random random = new Random();
    
    for (int i = 0; i < 10000; i++)
    {
        int rolledNumber = random.Next(0, 11); 
        counts[rolledNumber]++;
    }
    
    Console.WriteLine("Number occurrences after 10,000 rolls:");
    for (int i = 0; i < counts.Length; i++)
    {
        Console.WriteLine($"Number {i}: {counts[i]} times");
    }
}
RandomCounts();