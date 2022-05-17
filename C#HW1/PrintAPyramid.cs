// See https://aka.ms/new-console-template for more information
for (int i=1; i<6; i++)
{
    for (int j=5-i; j>0; j--)
    {
        Console.Write(" ");
    }
    for (int k=i*2-1; k>0; k--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
