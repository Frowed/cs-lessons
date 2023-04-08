// №1

Console.Write("введите первое число: ");
int first = int.Parse(Console.ReadLine()!);
Console.Write("введите второе число: ");
int second = int.Parse(Console.ReadLine()!);
int max = first;
int min = second;

if(first < second) {
    max = second;
    min = first;
}
Console.Write($"Max: {max} \nMin: {min}");

