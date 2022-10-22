double[] GenereateArray(int length) {
    double[] arr = new double[length];
    int i = 0;
    while (i < length) {
        Console.Write($"Введите {i+1} координату: ");
        arr[i] = Convert.ToDouble(Console.ReadLine());
        i++;
    }
    return arr;
}

double countDistance(double[] pointA, double[] pointB) {
    int i = 0;
    double s = 0;
    while (i < pointA.Length) {
        s += Math.Pow(pointB[i] - pointA[i], 2);
        i++;
    }
    return Math.Pow(s, 0.5);
}

double[][] points2D = new double[2][];
double[][] points3D = new double[2][];
int i = 0;

while (i < 2) {
    Console.WriteLine($"{i+1} точка в 2D плоскости: ");
    points2D[i] = GenereateArray(2);
    Console.WriteLine($"{i+1} точка в 3D плоскости: ");
    points3D[i] = GenereateArray(3);
    i++;
}

Console.WriteLine($"Расстояние между точками в 2D равно: {countDistance(points2D[0], points2D[1])}");
Console.WriteLine($"Расстояние между точками в 3D равно: {countDistance(points3D[0], points3D[1])}");