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

int[,] CreateRandomSquareArr(int m) {
    Console.WriteLine($"m = {m}");
    int[,] arr = new int[m,m];
    int i = 0;

    while (i < m) {
        int j = 0;
        while (j < m) {
            arr[i, j] = new Random().Next(1, 10);
            j++;
        }
        i++;
    }

    WriteArr(arr);

    return arr;
}

int[,] MultiplyArrays(int[,] a, int[,] b) {
    int rows = a.GetUpperBound(0) + 1;
    int columns = a.Length / rows;
    int[,] c = new int[rows,columns];

    for (int i = 0; i < rows; i++)
    {
        int rowNumber = 1;
        int columnNumber = 1;
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                rowNumber *= a[i,k];
                columnNumber *= b[k,j];
            }
            c[i,j] = rowNumber + columnNumber;
            rowNumber = 1;
            columnNumber = 1;
        }
    }

    return c;
}

Console.WriteLine("Введите размер массивов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] a = CreateRandomSquareArr(m);
int[,] b = CreateRandomSquareArr(m);

int[,] c = MultiplyArrays(a, b);

WriteArr(c);