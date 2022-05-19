// See https://aka.ms/new-console-template for more information
int[] array1 = new int[10] {1,2,3,4,5,6,7,8,9,10};
int[] array2 = new int[array1.Length];
for (int i = 0; i < array1.Length; i++)
{
    array2[i] = array1[i];
}

Console.Write("Array1: ");
for (int i = 0; i < array1.Length; i++)
{
    Console.Write(array1[i]);
    Console.Write(",");
}

Console.WriteLine();
Console.Write("Array2: ");
for (int i = 0; i < array1.Length; i++)
{
    Console.Write(array2[i]);
    Console.Write(",");
}

