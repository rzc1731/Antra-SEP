// See https://aka.ms/new-console-template for more information

int[] inputArray = new int[5] {1,2,3,4,5};
int k = 3;
int n = inputArray.Length;
int[] outputArray = new int[n];

for (int r=1; r<=k; r++)
{
    for (int i=0; i<n; i++)
    {
        outputArray[i] = outputArray[i] + inputArray[(i-r+n)%n];
    }
}

for (int i=0; i<n; i++)
{
    Console.Write(outputArray[i] + " ");
}
