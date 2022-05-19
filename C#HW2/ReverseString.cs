// See https://aka.ms/new-console-template for more information
using System.Text;
String str = Console.ReadLine();
char[] chars = str.ToCharArray();
Array.Reverse(chars);
String res = new string(chars);
Console.WriteLine(res);


int i = str.Length - 1;
int start, end = i + 1;
StringBuilder result = new StringBuilder("");

for (; i >= 0; i--)
{
    result.Append(str[i]);
}

Console.WriteLine(result);

char[] delimiterChars = { '.',',', ':',';','=','(',')','&','[',']','"','\'','\\','/','!','?',' '};
//return String.Join(" ", str.Split(delimiterChars).Reverse()).ToString();

static string ReverseString(string s)
{
    StringBuilder sb = new StringBuilder();
    string[] words = s.Split(' ');

    for (int i = words.Length-1; i >= 0; i--)
    {
        sb.Append(words[i]);
        sb.Append(' ');
    }
    return sb.ToString();
}

Console.WriteLine(ReverseString("C# is not C++, and PHP is not Delphi!"));
Console.WriteLine(ReverseString("The quick brown fox jumps over the lazy dog / Yes! Really!!! /."));