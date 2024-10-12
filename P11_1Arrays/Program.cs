
void asking()
{
    Console.Write("How many numbers would you like to input? ");
    int size = int.Parse(Console.ReadLine());
    
    double[] numbers = new double[size];
    
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter number {i + 1}: ");
        numbers[i] = double.Parse(Console.ReadLine());
    }

    
    Console.Write("What number are you looking for? ");
    double target = double.Parse(Console.ReadLine());

    
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == target)
        {
            count++;
        }
    }

    
    Console.WriteLine($"The number {target} occurs {count} times in the array.");
}
asking();