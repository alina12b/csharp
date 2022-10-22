Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > -100 && a < 100) Console.Write($"У числа {a} третьей цифры нет");
else if (a < 0) Console.Write(Convert.ToString(a)[3]);
else Console.Write(Convert.ToString(a)[2]);