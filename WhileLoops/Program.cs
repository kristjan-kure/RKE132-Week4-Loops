//While loop
Random rnd = new Random();
int cpuRandom;

bool loopActive = true; //true or false

while (loopActive)
{
    cpuRandom = rnd.Next(1, 3);
    Console.WriteLine($"CpuRandom: {cpuRandom}");
    Console.WriteLine("Make a guess. Enter a number 1-2");

    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom) {
        Console.WriteLine("Congratulations, you won!");
        //loopActive = false;
        break;
    }
    else
    {
        Console.WriteLine("Oops, try again!");
    }
}

Console.WriteLine("Have a nice day!");


