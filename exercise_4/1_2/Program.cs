int num = int.Parse(Console.ReadLine()!);
int buff = 0;

while(num > 0) {
    buff += num % 10;
    num = num / 10;
}

Console.WriteLine(buff);