Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(" Enter number 1 : ");
int Input_User = int.Parse(Console.ReadLine());
int conter = 0;
int sum = 1;

while (Input_User != conter)
{
    conter++;
    sum *= conter;
}

Console.WriteLine(sum);