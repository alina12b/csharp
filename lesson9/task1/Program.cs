void TypeEvens(int n) {
    if (n == 1) return;

    if (n % 2 == 0) Console.Write($"{n} ");

    TypeEvens(n - 1);
}

Console.WriteLine("Введите N:");

int n = Convert.ToInt32(Console.ReadLine());

TypeEvens(n);
