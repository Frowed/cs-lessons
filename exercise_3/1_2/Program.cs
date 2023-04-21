Console.WriteLine("Введите 3 числа подряд для точки A");
int a1 = int.Parse(Console.ReadLine()!);
int a2 = int.Parse(Console.ReadLine()!);
int a3 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите 3 числа подряд для точки A");
int b1 = int.Parse(Console.ReadLine()!);
int b2 = int.Parse(Console.ReadLine()!);
int b3 = int.Parse(Console.ReadLine()!);

Console.Write(Math.Sqrt(Math.Pow(b2-a2, 2) + Math.Pow(b1-a1, 2) + Math.Pow(b3-a3, 2)));