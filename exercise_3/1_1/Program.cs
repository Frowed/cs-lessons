int a = 12322;
// Console.WriteLine(a / 10000);
// Console.WriteLine(a % 10);
Console.WriteLine(a / 10000 == a % 10 ? "1 и 5 цифры равны" : "1 и 5 цифры не равны");

// Console.WriteLine(a / 1000 - (a / 10000 * 10));
// Console.WriteLine((a % 100) / 10);
Console.WriteLine(a / 1000 - (a / 10000 * 10) == (a % 100) / 10 ? "2 и 4 цифры равны" : "2 и 4 цифры не равны");


if(a / 10000 == a % 10 && a / 1000 - (a / 10000 * 10) == (a % 100) / 10) {
    Console.Write("Число - палиндром");
} else {
    Console.Write("Число - не палиндром");
}