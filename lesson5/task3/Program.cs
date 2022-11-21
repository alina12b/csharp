double[] createRandomArrToMax(int max) {
    int length = new Random().Next(10, 30);
    double[] arr = new double[length];
    int i = 0;

    while (i < length) {
        arr[i] = new Random().NextDouble() * max;
        Console.Write($"{arr[i]} ");
        i++;
    }
    Console.WriteLine();

    return arr;
}

double findDifferenceBetweenMaxAndMin(double[] arr) {
    double min = arr[0];
    double max = arr[0];
    foreach (double num in arr) {
        if (num > max) {
            max = num;
        } else if (num < min) {
            min = num;
        }
    }
    Console.WriteLine($"min: {min}");
    Console.WriteLine($"max: {max}");
    return max - min;
}

double[] arr = createRandomArrToMax(100);
double diff = findDifferenceBetweenMaxAndMin(arr);
Console.Write($"Разница между максимальным и минимальным значением: {diff}");