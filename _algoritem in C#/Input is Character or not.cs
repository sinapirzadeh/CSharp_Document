Console.WriteLine("Enter Character : ");
string number = Console.ReadLine()[0].ToString();

bool IsInt = int.TryParse(number, out int value);
Console.WriteLine($"{IsInt} - {value}");