Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b * b && b == a * a) Console.Write("Джекпот! Числа являются квадратами друг друга!");
else if (a == b * b) Console.Write($"{a} = {b} * {b}");
else if (b == a * a) Console.Write($"{b} = {a} * {a}");
else Console.Write("Оба числа не связаны квадратом одного из них");