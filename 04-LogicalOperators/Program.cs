Console.WriteLine("Enter your name:");
string name = Console.ReadLine()!;

Console.WriteLine("Enter your age:");
if (int.TryParse(Console.ReadLine(), out int age))
{
    Console.WriteLine("Are you member? (true/false)");
    string member = Console.ReadLine()!;

    if (bool.TryParse(member, out bool isMember))
    {
        if (age >= 18 && isMember)
        {
            Console.WriteLine($"Welcome, {name}");
            Console.WriteLine("You can enter.");
        }
        else
        {
            Console.WriteLine($"Sorry, {name}");
            Console.WriteLine("You cannot enter.");
        }
    }
    else
    {
        Console.WriteLine("Please enter only true or false.");
    }
}
else
{
    Console.WriteLine("Please enter a valid age.");
}