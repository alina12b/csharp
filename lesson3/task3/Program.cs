Console.Write("Введите номер дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 1 || a > 7) Console.Write("Дней в неделе всего 7, в следующий раз введите правильно"); 
else if (a < 6) Console.Write("Это будний день");
else Console.Write("Ура, это выходной");