Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int aCopy = a;
if (a < 0) a = a * (-1);
int res = 0;

while (a != 0) {
    int rem = a % 10;
    res += rem;
    a = (a - rem)/10;
}
Console.Write($"Сумма цифр числа {aCopy} равна {res}");
