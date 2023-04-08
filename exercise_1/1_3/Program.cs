// №3

Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine()!);
int rest = number % 2;

if(number % 2 == 1 || number % 2 == -1) {
    Console.Write("Число нецелое");
} else {
    Console.Write("Число целое");
}

