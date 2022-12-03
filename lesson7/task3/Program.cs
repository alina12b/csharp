int[,] CreateRandomArr() {
    int m = new Random().Next(1, 50);
    Console.WriteLine($"m = {m}");
    int n = new Random().Next(1, 50);
    Console.WriteLine($"n = {n}");
    int[,] arr = new int[m,n];
    int i = 0;

    while (i < m) {
        int j = 0;
        while (j < n) {
            arr[i, j] = new Random().Next(0, 50);
            Console.Write($"{arr[i, j]} ");
            j++;
        }
        Console.WriteLine();
        i++;
    }

    return arr;
}

void FindAmount(int[,] arr) {
    int rows = arr.GetUpperBound(0) + 1;
    int columns = arr.Length / rows;
    double[] amounts = new double[columns];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            amounts[j] += arr[i, j];
        }
    }

    Console.WriteLine("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < columns; j++)
    {
        amounts[j] /= rows;
        Console.Write($"{amounts[j]} ");
    }

    return;
}

int[,] arr = CreateRandomArr();

FindAmount(arr);