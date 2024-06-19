// See https://aka.ms/new-console-template for more information
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
}

Console.ReadKey();