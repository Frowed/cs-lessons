// №2

Console.Write("введите первое число: ");
int first = int.Parse(Console.ReadLine()!);
Console.Write("введите второе число: ");
int second = int.Parse(Console.ReadLine()!);
Console.Write("введите третье число: ");
int third = int.Parse(Console.ReadLine()!);
int max = first;

if(second > max) max = second;
if(third > max) max = third;
Console.Write($"Max: {max}");

