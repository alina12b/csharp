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
            j++;
        }
        i++;
    }

    WriteArr(arr);

    return arr;
}

int[,] SortArr(int[,] arr) {
    int rows = arr.GetUpperBound(0) + 1;
    int columns = arr.Length / rows;
    
    for (int i = 0; i < rows; i++)
    {
        int temp;

        for (int j = 0; j < columns; j++)
        {
            for (int k = j + 1; k < columns; k++)
            {
                if (arr[i, j] < arr[i, k])
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }

    return arr;
}

int[,] arr = CreateRandomArr();

int[,] sortedArr = SortArr(arr);

WriteArr(sortedArr);