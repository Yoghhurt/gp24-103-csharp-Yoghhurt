//P05_0
void things()
{
    Console.WriteLine("Marc");
    Console.WriteLine("Game Programming");
    Console.WriteLine("Forsbergs");
}

things();
//P05_1
void multiply(int number)
{
    Console.WriteLine(number*2);
}
multiply(5);
multiply(-2);
multiply(0);
multiply(100);
multiply(1000000000);
multiply(2000000000);
//P05_1_2

void cube(int cubical)
{
    Console.WriteLine(cubical*cubical*cubical);
}
cube(1);
cube(0);
cube(2);
cube(3);
cube(-4);

//P05_1_3
void square(float sq)
{
    Console.WriteLine(sq*sq*sq*sq);
}
square(0.5f);
square(-2f);
square(0f);
square(4.2f);
//P05_1_4

void primer(int prime)
{
    Console.WriteLine(prime);
    if (prime > 1);
}
//P05_1_5
void count(int countdown)
{
    if (countdown > 1)    
        countdown--;
    Console.WriteLine(countdown--);
    
}
count(10);

//P05 final

void fibonaccinumber(int num)
{
    int n = 10; 
}

static int Fibonacci(int n)
{
    int a = 0, b = 1, temp;

    for (int i = 0; i < n; i++)
    {
        temp = a;
        a = b;
        b = temp + b;
    }

    return a;
}