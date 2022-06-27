Console.WriteLine("What is your name?");
string name = Console.ReadLine();
bool loop = true;
while (loop == true)
{
    Console.WriteLine("Ok, " + name + ", Please enter a number between 1 and 100.");
    int input = int.Parse(Console.ReadLine());
    if (input < 1 || input > 100)
    {
        Console.WriteLine("You did not enter a positive number between 1 and 100.");
    }
    else if (input < 60 && input % 2 != 0)
    {
        Console.WriteLine(input + ". this number is odd and less than 60.");
    }
    else if (input <= 24 && input > 2)
    {
        Console.WriteLine(input + ". this number is even and less than 25.");
    }
    else if (input >= 26 && input <= 60)
    {
        Console.WriteLine(input + ". Even and between 26 and 60 inclusive.");
    }
    else if (input > 60 && input % 2 == 0)
    {
        Console.WriteLine(input + ". Even and greater than 60.");
    }
    else if (input > 60 && input % 2 != 0)
    {
        Console.WriteLine(input + ". Odd and greater than 60.");
    }
    Console.WriteLine("would you like to go again " + name + "? y/n");
    string input2 = Console.ReadLine();
    if (input2 == "y")
    {
        Console.WriteLine("Ok, here we go again!\n");
        loop = true;
    }
    else if (input2 == "n")
    {
        Console.WriteLine("We're done here.");
        loop = false;
    }
}
