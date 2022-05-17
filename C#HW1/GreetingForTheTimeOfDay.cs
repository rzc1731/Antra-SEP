// See https://aka.ms/new-console-template for more information

//DateTime now = new DateTime(2022, 5, 17, 11, 24, 16);
DateTime now = DateTime.Now;

if (now.Hour >= 5 && now.Hour < 12)
{
    Console.WriteLine("Good Morning");
}
if (now.Hour >= 12 && now.Hour < 17)
{
    Console.WriteLine("Good Afternoon");
}
if (now.Hour >= 17 && now.Hour < 23)
{
    Console.WriteLine("Good Evening");
}
if (now.Hour >= 23 || now.Hour < 5)
{
    Console.WriteLine("Good Night");
}
