Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c) Console.Write($"Большее число a: {a}");
else if (b > a && b > c) Console.Write($"Большее число b: {b}");
else if (c > a && c > b) Console.Write($"Большее число c: {c}");
else if (a > b) Console.Write($"Большие числа a и с: {a}");
else if (a > c) Console.Write($"Большие числа a и b: {a}");
else if (c > a) Console.Write($"Большие числа b и с: {b}");
else Console.Write($"Все числа равны между собой");