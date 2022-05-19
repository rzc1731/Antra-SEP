// See https://aka.ms/new-console-template for more information
string url = "ftp://www.example.com/employee";

bool hasP = false;
bool hasR = false;

int firstIndex = url.IndexOf("://");
if (firstIndex == -1)
{
    firstIndex = -3;
} else
{
    hasP = true;
}
int secondIndex = url.Substring(firstIndex + 3).IndexOf("/");
if (secondIndex == -1)
{
    secondIndex = url.Length - firstIndex - 3;
} else
{
    hasR = true;
}

if (hasP)
{
    Console.WriteLine("[protocol] = \"" + url.Substring(0, firstIndex) + "\"");
} else
{
    Console.WriteLine("[protocol] = \"\"");
}
Console.WriteLine("[server] = \"" + url.Substring(firstIndex + 3, secondIndex) + "\"");

if (hasR)
{
    Console.WriteLine("[resource] = \"" + url.Substring(secondIndex + firstIndex + 4) + "\"");
} else
{
    Console.WriteLine("[resource] = \"\"");
}