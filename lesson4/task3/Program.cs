int length = 8;
int[] arr = new int[length];
int i = 0;
while (i < length) {
    Console.Write($"Введите {i+1} число: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
Console.Write("[ ");
foreach (int num in arr) {
    Console.Write($"{num} ");
}
Console.Write("]");