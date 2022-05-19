// See https://aka.ms/new-console-template for more information

List<String> Mylist = new List<string>();

while (true)
{
    Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
    String command = Console.ReadLine();
    if (command[0] == '-' && command[1] == '-')
    {
        Mylist.Clear();
    }
    else if (command[0] == '+')
    {
        Mylist.Add(command.Substring(1));
    }
    else if (command[0] == '-')
    {
        if (!Mylist.Remove(command.Substring(1)))
        {
            Console.WriteLine("Cannot remove non-exist element.");
        }
    }
    else
    {
        Console.WriteLine("Invalid command");
    }
    Console.WriteLine("Current List: ");
    foreach (string s in Mylist)
    {
        Console.WriteLine(s);
    }
}
