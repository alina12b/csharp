Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int i = 2;
if (a >= i) 
{
    Console.Write(i);
    i = i + 2;
    while (a >= i)
    {
        Console.Write($", {i}");
        i = i + 2;
    }
    Console.Write(".");
}
else
{
    Console.Write($"Четных чисел меньше {a} нет");
}