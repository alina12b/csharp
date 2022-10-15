Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 1) Console.Write($"Число {a} нечётное");
else Console.Write($"Число {a} чётное");