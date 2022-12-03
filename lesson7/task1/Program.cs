int[,] createRandomArr(int m, int n) {
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

Console.WriteLine("Введите нужный размер массива:");

Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = createRandomArr(m, n);