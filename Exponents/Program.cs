bool loop = true;
do
{
Console.WriteLine("Enter an integer: ");
int input = int.Parse(Console.ReadLine());
    if (input <= 0)
    {
        Console.WriteLine("Please try again");
    }
    else if (input > 1290)
    {
        Console.WriteLine("Too high. Please try again.");
    }
    else
    {
        Console.WriteLine(string.Format("{0,10} | {1,10} | {2,10} |", "Number", "Squared", "Cubed"));
        Console.WriteLine(string.Format("{0,10} | {1,10} | {2,10} |", "-----", "-----", "-----"));
        for (int i = 1; i <= input; i++)
        {
            Console.WriteLine(string.Format("{0,10} | {1,10} | {2,10} |", i, NumberSquared(i), NumberCubed(i)));
        }
        Console.WriteLine("Do you want to continue? y/n");
        string userInput = Console.ReadLine();
        if (userInput == "y")
        {
            loop = true;
        }
        else
        {
            loop = false;
            break;
        }
    }

} while (loop != false);

//methods
static int NumberSquared(int input)
{
    return input * input;
}

static int NumberCubed(int input)
{
    return input * input * input;
}