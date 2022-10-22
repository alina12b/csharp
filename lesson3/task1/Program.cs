Console.Write("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < -999 || (a > -100 && a < 100) || a > 999) Console.Write("Надо было трёхзначное");
else if (a < 0) Console.Write(Convert.ToString(a)[2]);
else Console.Write(Convert.ToString(a)[1]);