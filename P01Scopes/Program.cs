{
    {
       
        Console.WriteLine("Give me a number.");
        string inputString = Console.ReadLine();
        
        if (int.TryParse(inputString, out _))
        {
            Console.WriteLine($"{inputString}1"); 
        }
        
        Console.WriteLine("Give me another number.");
        string inputIntString = Console.ReadLine();
        
        if (int.TryParse(inputIntString, out int inputInt))
        {
            inputInt++; 
            Console.WriteLine(inputInt); 
        }
        
        
        Console.WriteLine("Give me another number.");
        string inputCharString = Console.ReadLine();
        
        if (inputCharString.Length == 1 && char.TryParse(inputCharString, out char inputChar))
        {
            inputChar++; 
            Console.WriteLine(inputChar); 
        }
      
    }
}