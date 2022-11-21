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

int countSumOfOddNumbers(int[] arr) {
    int res = 0;
    int i = 1;
    while (i < arr.Length) {
        res += arr[i];
        i += 2;
    }
    return res;
}

int[] arr = createRandomArrInRange(-100, 100);
int sum = countSumOfOddNumbers(arr);
Console.Write($"Сумма чисел на нечетных местах: {sum}");