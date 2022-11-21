int[] createRandomArrInRange(int min, int max) {
    int length = new Random().Next(10, 30);
    int[] arr = new int[length];
    int i = 0;

    while (i < length) {
        arr[i] = new Random().Next(min, max);
        Console.Write($"{arr[i]} ");
        i++;
    }
    Console.WriteLine();

    return arr;
}

int countEvenNumbers(int[] arr) {
    int res = 0;
    foreach (int num in arr) {
        if (num % 2 == 0) {
            res++;
        }
    }
    return res;
}

int[] arr = createRandomArrInRange(100, 1000);
int even = countEvenNumbers(arr);
Console.Write($"Количество четных чисел: {even}");