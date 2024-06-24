var todos = new List<string>();

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
        shallExit = true;
        break;
    case "S";
    case "s";
        Console.WriteLine("See all TODOs");
        break;
    case "A";
    case "a";
        AddTodo();
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

void AddTodo()
{
    Console.WriteLine("Enter the TODO description");
    var description = Console.ReadLine();

    if(description == "")
    {
        Console.WriteLine("The description cannot be empty");
    }
    else if(todos.Contains(description))
    {
        Console.WriteLine("the description must be unique.");
    }
    else
    {
        todos.Add(description);
    }
}