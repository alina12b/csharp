int FunctionAkkerman(int m, int n) {
    if (m == 0) return n + 1;

    else if ((m != 0) && (n == 0)) return FunctionAkkerman(m - 1, 1);

    return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}

Console.WriteLine("Введите M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N:");
int n = Convert.ToInt32(Console.ReadLine());

int res = FunctionAkkerman(m, n);

Console.WriteLine($"A({m}, {n}) = {res}");