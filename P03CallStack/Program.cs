//P03_1

{
    DrawTriangle(5); 
}

static void DrawTriangle(int rows)
{
    
    if (rows <= 0)
    {
        return;
    }

    
    Console.WriteLine(new string('#', rows));

    
    DrawTriangle(rows - 1);
}

//P03_2
void F1(){
    Console.Write("A"); // A
}
void F2(){
    Console.Write("B"); // BA
    F1();
}
void F3(){
    F1();
    Console.Write("-"); // A-BA
    F2();
}
void F4(){
    Console.Write("-"); // -A
    F1();
}

F2();
F3();
F2();
F4();
F1();
F1();
F4();
F3();



//P03 final 

{
    static void Countdown()
    {
        int timer = 5;
        Console.WriteLine(timer);

        
        timer--;

        
        if (timer >= 1)
        {
            
            Countdown();
        }
        else
        {
            
            Console.WriteLine("Launch!");
        }
    }

    static void Main()
    {
        
        Countdown();
    }
}
