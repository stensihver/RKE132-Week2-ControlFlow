// See https://aka.ms/new-console-template for more information



Console.WriteLine("Please, select your gender (m/f):");

char userGender = char.Parse(Console.ReadLine());
Console.WriteLine("Please, enter your lastname;");

string userlastname = Console.ReadLine();

if(userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr.{userlastname}!");
}
else if(userGender == 'f')
{
    Console.WriteLine("$Welcome, Ms.{userlastname}!");
}
else
{
    Console.WriteLine("$Welcome, {userlastname}!");
}
