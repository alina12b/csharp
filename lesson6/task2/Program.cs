int[] CreateLine() {
    int[] arr = new int[2];
    Console.Write("k = ");
    arr[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("b = ");
    arr[1] = Convert.ToInt32(Console.ReadLine());

    return arr;
}

void FindIntersectionPoint(int[] firstLine, int[] secondLine) {
    int k1 = firstLine[0];
    int k2 = secondLine[0];
    int b1 = firstLine[1];
    int b2 = secondLine[1];
    if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают, точки пересечения везде");
    else if (k1 == k2) Console.WriteLine("Прямые параллельны, точек пересечения нет");
    else {
        double x = (b1 - b2) / (k2 - k1);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения двух прямых: [{x}; {y}]");
    }
    return;
}

Console.WriteLine("Задайте параметры для первой прямой:");
int[] firstLine = CreateLine();

Console.WriteLine("Задайте параметры для второй прямой:");
int[] secondLine = CreateLine();
FindIntersectionPoint(firstLine, secondLine);