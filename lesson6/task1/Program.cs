int[] CreateArr() {
    Console.WriteLine("Введите количество чисел, которые хотите ввести: ");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[length];
    int i = 0;

    Console.WriteLine("Введите же ваши числа: ");
    while (i < length) {
        arr[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }

    return arr;
}

int CountPositiveNums(int[] arr) {
    int count = 0;
    foreach (int num in arr) {
       count += Convert.ToInt32(num > 0);
    }
    Console.WriteLine($"Количество положительных чисел среди введенных: {count}");
    return count;
}

int[] arr = CreateArr();
int positives = CountPositiveNums(arr);