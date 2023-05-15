Console.WriteLine("Enter Your text 1 :");
string text1 = Console.ReadLine();

Console.WriteLine("Enter Your text 2 :");
string text2 = Console.ReadLine();

int MaxLength = text1.Length < text2.Length ? text2.Length : text1.Length;

string result = string.Empty;

for (int i = 0; i < MaxLength; i++)
{
    result = i < text1.Length ? result + text1[i] : result;

    result = i < text2.Length ? result + text2[i] : result;
}

Console.WriteLine($"Result is : {result}");