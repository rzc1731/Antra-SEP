// See https://aka.ms/new-console-template for more information
string text = "Hi, exe? ABBA! Hog fully a string: ExE. Bob";
string[] words = text.Split(' ', ',');

List<String> results = new List<String>();

bool isPali(String word)
{
    int back = word.Length - 1;
    for (int i = 0; i < word.Length / 2; i++)
    {
        if (word[i] != word[back])
        {
            return false;
        } else
        {
            back--;
        }
    }
    return true;
}

foreach (string word in words)
{
    string cleanWord = new string(word.Where(c => Char.IsLetter(c) || c == '\'').ToArray());
    if (!string.IsNullOrWhiteSpace(cleanWord) && isPali(cleanWord))
    {
        if (!results.Contains(cleanWord))
        {
            results.Add(cleanWord);
        }
    }
}

results.Sort();

Console.Write(results[0]);
for (int i = 1; i < results.Count; i++)
{
    Console.Write(", " + results[i]);
}