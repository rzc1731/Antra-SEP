// See https://aka.ms/new-console-template for more information

for( ; true; ) ;

uint centuries;
bool test = UInt32.TryParse(Console.ReadLine(), out centuries);
if (!test)
{
    Console.WriteLine("Input must be an integer");
}

uint years = centuries * 100;
uint days = Convert.ToUInt32(centuries * 36524.25);
ulong hours = days * 24;
ulong minutes = hours * 60;
ulong seconds = minutes * 60;
ulong milliseconds = seconds * 1000;
ulong microseconds = milliseconds * 1000;
ulong nanoseconds = microseconds * 1000;

Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} " +
    $"minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = " +
    $"{nanoseconds} nanoseconds");