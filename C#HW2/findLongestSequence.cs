// See https://aka.ms/new-console-template for more information
int[] inputArray = new int[4] {4,4,4,4};

int[] findLongestSequence(int[] input)
{
    int cur_longest_start = 0;
    int best_longest_start = 0;
    int cur_longest_len = 1;
    int best_longest_len = 1;
    for (int i = 1; i < input.Length; i++)
    {
        if (input[i] != input[i-1])
        {
            if (cur_longest_len > best_longest_len)
            {
                best_longest_len = cur_longest_len;
                best_longest_start = cur_longest_start;
            }
            cur_longest_start = i;
            cur_longest_len = 1;
        }
        else
        {
            cur_longest_len++;
        }
    }
    if (cur_longest_len > best_longest_len)
    {
        best_longest_len = cur_longest_len;
        best_longest_start = cur_longest_start;
    }

    int[] result = new int[best_longest_len];
    int start = 0;
    for (int i=best_longest_start; i<best_longest_start+best_longest_len; i++)
    {
        result[start] = input[i];
        start++;
    }
    return result;
}

int[] test = findLongestSequence(inputArray);
for (int i=0; i<test.Length; i++)
{
    Console.WriteLine(test[i]);
}