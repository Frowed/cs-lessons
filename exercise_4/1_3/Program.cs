int[] arr = new int[8];
for(int i = 0; i < 8; i++) {
    arr[i] = new Random().Next(0, 100);
}

void PrintArr(int[] array) {
    Console.Write("[");
    for(int i = 0; i < 8; i++) {
        Console.Write(arr[i]);
        if(i == 7) break;
        Console.Write(",");
    }
    Console.Write("]");
}

PrintArr(arr);