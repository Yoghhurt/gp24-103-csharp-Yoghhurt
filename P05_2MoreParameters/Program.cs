using System.ComponentModel.Design;

void PrintWelcomeMessage(string firstName, string lastName){
    Console.WriteLine($"Welcome {firstName} {lastName}");
}
PrintWelcomeMessage("Marc", "Zaku");
PrintWelcomeMessage("James", "Bond");
PrintWelcomeMessage("Michael", "Jackson");

//P05_1

void Average(int a, int b)
{
    int average = a + b / 2;
    Console.WriteLine($"Average number is {average}");
}
Average(2, 6);
Average(0, 10);
Average(-12, 12);
Average(11, 9);

//P05_2

void PowerOf(int x, int y)
{
    int pow = (x * y) * y;
    Console.WriteLine($"Result: {pow}");
}

PowerOf(3, 2);
PowerOf(5, 1);
PowerOf(2, 5);
PowerOf(2, 10);
PowerOf(19, 0);
PowerOf(13, 1);

void numRandom(double min, double max)
{
    Random random = new Random();
    double randomNumber = random.NextDouble() * (max - min) + min;
    Console.WriteLine($"random number is {randomNumber}");
}
numRandom(3, 7);

//P05_3

void GetUserRandomNumber(int minimum, int maximum)
{
    Console.WriteLine($"Gimme a number between {minimum} and {maximum}");
    string userNumber = Console.ReadLine();
    int userInt = int.Parse(userNumber);
    {
        if (userInt >= minimum && userInt <= maximum) ;
        Console.WriteLine("Correct!");
    }
}
GetUserRandomNumber(1, 10);

//P052

// the const keyword makes it so the values assigned to the
// variables cannot be changed during runtime
// this makes it more obvious, that these are configuration variables
const int deltaTimeMs = 1000 / 30;
const float deltaTime = deltaTimeMs / 1000f;
const int width = 30; // Change, if you like :)
const float animationDuration = 1f; // Change, if you like :)
float start = 0f;
float end = width;
float position = start;
float timePassed = 0f;

// -----------------------------------
// TODO: Implement the missing functions between here...
float Lerp(float from, float to, float t)
{
    from = 0f;
    to = 1f;
    t = 1f;
    
    start = from;
    end = from + (to - from);
    timePassed = from + (to - from) * t;
    return from + to + t;
}

int RoundToInt(float value)
{
    int inter = Convert.ToInt32(value);
    int intValue = (int)value;
    return intValue;
}
// and here!
// -----------------------------------

void Update()
{
    // we increase the passedTime by deltaTime
    // we divide the deltaTime by animationDuration
    // this causes time to reach value 1 (the end) within 1 seconds for 1 second duration
    // but in half the time (two seconds) if passing in 2 seconds for duration
    timePassed += deltaTime / animationDuration;
    // lerp will linearly interpolate the position between start and end
    // for value 0, it will be at start, for value 1, it will be at end
    // for value 0.5, it will be in the middle
    position = Lerp(start, end, timePassed);
    if (timePassed > 1f)
    {   // bounce back:
        // we set start to become end and end to become start:
        // ADVANCED: in case you're wondering, the technique used here are called ValueTuples
        (start, end) = (end, start);
        // we reset the timePassed, so it begins the animation
        timePassed = 0;
    }
}

void Render()
{
    // we need to find out the closest position for the player
    // e.g. the player might be at position 2.3f
    // in that case, we want to render him at dash number 2.
    int closestIndex = RoundToInt(position);
    Console.Write('|');
    for (int i = 0; i <= width; i++)
    {
        Console.Write(i == closestIndex ? 'O' : '-');
    }
    Console.WriteLine('|');
}

// A very typical game loop:
GameLoop:
Console.SetCursorPosition(0, 0); // first, we reset the cursor
Update(); // then, we update all of our game objects
Render(); // then, we render everything to the screen
Thread.Sleep(deltaTimeMs); // 30FPS is enough for us :)
goto GameLoop;