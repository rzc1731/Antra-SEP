// See https://aka.ms/new-console-template for more information
static int[] FindPrimesInRange(int startNum, int endNum)
{
    List<int> primes = new List<int>();
    for (int i = startNum; i <= endNum; i++)
    {
        if (i == 1 || i == 0)
            continue;
        bool flag = true;

        for (int j = 2; j <= i / 2; ++j)
        {
            if (i % j == 0)
            {
                flag = false;
                break;
            }
        }
        if (flag)
            primes.Add(i);
    }
    int[] ps = primes.ToArray();
    return ps;
}

int[] result = FindPrimesInRange(1, 20);
for (int i=0; i<result.Length; i++)
{
    Console.WriteLine(result[i]);
}
