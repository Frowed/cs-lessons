Console.WriteLine("enter num");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter limit");
int lim = int.Parse(Console.ReadLine()!);
int temp = num;


for(int i = 1; i <= lim; i++) {
    Console.WriteLine($"Число в степени {i} = {Math.Pow(num, i)}");
}