Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(" Enter number 1 : ");
string Input_user = Console.ReadLine();
Console.Beep();

int input_user_int = 0;

foreach (char item in Input_user)
{
    Console.Beep();
    input_user_int += int.Parse(item.ToString());
}

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(input_user_int);