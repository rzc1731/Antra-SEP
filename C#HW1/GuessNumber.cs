// See https://aka.ms/new-console-template for more information
int correctNumber = new Random().Next(3) + 1;
int guessedNumber = int.Parse(Console.ReadLine());

if (guessedNumber < 1 || guessedNumber > 3)
{
    Console.WriteLine("guessed out of range");
}
else if (correctNumber > guessedNumber)
{
    Console.WriteLine("guessed low");
}
else if (correctNumber < guessedNumber)
{
    Console.WriteLine("guessed high");
}
else if (correctNumber == guessedNumber)
{
    Console.WriteLine("guessed correct");
}