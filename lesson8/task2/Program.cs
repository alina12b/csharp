void WriteArr(int[,] arr) {
    int rows = arr.GetUpperBound(0) + 1;
    int columns = arr.Length / rows;

    int i = 0;
    while (i < rows) {
        int j = 0;
        while (j < columns) {
            Console.Write($"{arr[i, j]} ");
            j++;
        }
        Console.WriteLine();
        i++;
    }
    Console.WriteLine();
    return;
}

int[,] CreateRandomSquareArr() {
    int m = new Random().Next(1, 10);
    Console.WriteLine($"m = {m}");
    int[,] arr = new int[m,m];
    int i = 0;

    while (i < m) {
        int j = 0;
        while (j < m) {
            arr[i, j] = new Random().Next(0, 10);
            j++;
        }
        i++;
    }

    WriteArr(arr);

    return arr;
}

int FindMinRow(int[,] arr) {
    int rows = arr.GetUpperBound(0) + 1;
    int columns = arr.Length / rows;
    int minRow = 0;
    int minSum = 0;
    for (int j = 0; j < columns; j++)
    {
        minSum += arr[0, j];
    }
    
    for (int i = 1; i < rows; i++)
    {
        int sumInRow = 0;

        for (int j = 0; j < columns; j++)
        {
            sumInRow += arr[i, j];
        }

        if (sumInRow < minSum) {
            minRow = i;
            minSum = sumInRow;
        }
    }

    return minRow + 1;
}

int[,] arr = CreateRandomSquareArr();

int minRow = FindMinRow(arr);

Console.WriteLine($"Минимальная сумма в строке: {minRow}");