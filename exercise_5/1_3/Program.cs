int[] arr = new int[5];
int max = 0;
int min = 100;
for (int i = 0; i < arr.GetLength(0); i++)
{
    arr[i] = new Random().Next(0, 100);
    Console.WriteLine(arr[i]);
}
    Console.WriteLine();

for (int i = 0; i < arr.GetLength(0); i++)
{
    min = arr[i] < min ? arr[i] : min;
    max = arr[i] > max ? arr[i] : max;
}
    Console.WriteLine($"минимал - {min}");
    Console.WriteLine($"Максимал - {max}");
    Console.WriteLine($"Разница - {max - min}");