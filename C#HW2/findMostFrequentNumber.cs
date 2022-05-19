// See https://aka.ms/new-console-template for more information
int[] inputArray = new int[11] { 7,7,7,0,2,2,2,0,10,10,10};

int findMostFrequentNumber(int[] input)
{
    Dictionary<int, int> dict = new Dictionary<int, int>();

    int n = input.Length;
    for (int i = 0; i < n; i++)
    {
        int key = input[i];
        if (dict.ContainsKey(key))
        {
            dict[key]++;
        }
        else
            dict.Add(key, 1);
    }

    int min_count = 0, res = -1;

    foreach (KeyValuePair<int,int> pair in dict)
    {
        if (min_count < pair.Value)
        {
            res = pair.Key;
            min_count = pair.Value;
        }
    }
    return res;
}
Console.WriteLine(findMostFrequentNumber(inputArray));
