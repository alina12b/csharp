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

void FindElementInArr(int[,] arr, int x, int y) {
    int rows = arr.GetUpperBound(0) + 1;
    int columns = arr.Length / rows;
    if (rows > x && columns > y) Console.WriteLine($"Ваш элемент: {arr[x, y]}");
    else Console.WriteLine("Нет такого элемента");
    return;
}

int[,] arr = CreateRandomArr();
Console.WriteLine("Введите координаты вашего элемента:");

Console.Write("x = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int y = Convert.ToInt32(Console.ReadLine());

FindElementInArr(arr, x, y);