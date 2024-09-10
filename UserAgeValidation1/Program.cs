// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter your age:");

string userage = Console.ReadLine();

int useragenum = 0;

bool isagenumber = Int32.TryParse(userage, out useragenum);

Console.WriteLine($"Parse result {isagenumber}. User is {useragenum} years old.");

if(isagenumber)
{
    if(useragenum >13)
    {
        Console.WriteLine("Welcome to Instagram.");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram!");
    }

}
else
{
    Console.WriteLine("could not read your age.");
}
