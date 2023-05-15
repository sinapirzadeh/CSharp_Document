Console.WriteLine("Enter Number 1 :");

var str = Console.ReadLine();

var words = str.Split(" ");

int conter = 0;

foreach (var item in words)
{
    if (item.Length % 2 == 0)
    {
        Console.WriteLine(item);
        Console.Beep();
        conter++;
    }
}
Console.WriteLine(conter);