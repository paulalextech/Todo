// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello");

bool shallExit = false;
while(!shallExit)
{

Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all todos");
Console.WriteLine("[A]dd a todo");
Console.WriteLine("[R]emove a todo");
Console.WriteLine("[E]xit?");


var userChoice = Console.ReadLine();

switch(userChoice) 
{
    case "E";
    case "e";
        Console.WriteLine("Exit");
        break;
    case "S";
    case "s";
        Console.WriteLine("See all TODOs");
        break;
    case "A";
    case "a";
        Console.WriteLine("Add a TODO");
        break;
    case "R";
    case "r";
        Console.WriteLine("Remove a TODO");
        break;
    default:
        Console.WriteLine("Invalid choice");
        break;
    }
}



Console.ReadKey();