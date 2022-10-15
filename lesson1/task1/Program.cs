Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) Console.Write($"Большее число {a}, a меньшее - {b}");
else if (a == b) Console.Write($"Оба числа {a} равны");
else Console.Write($"Большее число {b}, a меньшее - {a}");