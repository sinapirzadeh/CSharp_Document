Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(" Enter number 1 : ");
List<int> User_numbers = new List<int>();

int input_user = 1;

while (input_user <= 0)
{
    input_user = int.Parse(Console.ReadLine());
    User_numbers.Add(input_user);
}

Console.WriteLine(User_numbers.Min());
Console.WriteLine(User_numbers.Max());