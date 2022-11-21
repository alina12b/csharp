Console.Write("Введите возводимое в степень число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == 0 && b > 0) Console.Write($"0^{b} = 0");
else if (a == 0 && b == 0) Console.Write("0^0 = Неопределенность");
else if (a == 0 && b < 0) Console.Write("Ноль нельзя возвести в отрицательную степень");
else {
    int c = b;
    int res = 1;
    while (c != 0) {
        if (c > 0) {
            res = res * a;
            c--;
        } else {
            res = res / a;
            c++;
        }
    }
    Console.Write($"{a}^{b} = {res}");
}