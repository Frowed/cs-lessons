int[] arr = new int[5];
for (int i = 0; i < arr.GetLength(0); i++)
{
    arr[i] = new Random().Next(100, 1000);
}

for (int i = 0; i < arr.GetLength(0); i++)
{
    Console.WriteLine(arr[i] % 2 == 0 ? $"{arr[i]} - четное": $"{arr[i]} - нечетное");
}