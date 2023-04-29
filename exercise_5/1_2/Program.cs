int[] arr = new int[4];
int sum = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{
    arr[i] = new Random().Next(-20, 20);
    Console.WriteLine($"{i} число массива - {arr[i]}");
}

Console.WriteLine();

for (int i = 0; i < arr.GetLength(0); i++)
{
    if(i % 2 == 1) 
    {
        sum += arr[i];
    }
}

Console.Write(sum);