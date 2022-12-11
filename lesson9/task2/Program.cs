int FindSumBetween(int m,int n) {
    if (n < 1) return 0;

    if (m == n) return m;

    if (m < 1) return FindSumBetween(m + 1, n);

    return m + FindSumBetween(m + 1, n);
}

Console.WriteLine("Введите M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N:");
int n = Convert.ToInt32(Console.ReadLine());

int sum = FindSumBetween(m, n);

Console.WriteLine($"Сумма натуральных элементов между {m} и {n} равна {sum}");