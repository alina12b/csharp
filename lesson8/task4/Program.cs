void WriteArr(int[,,] arr) {
    int tables = arr.GetUpperBound(0) + 1;
    int rows = arr.GetUpperBound(1) + 1;
    int columns = arr.Length / (tables * rows);

    for (int i = 0; i < tables; i++) {
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                Console.Write($"{arr[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
    return;
}

int[,,] a = {{{11, 22}, {33, 44}}, {{55, 66}, {77, 88}}};

WriteArr(a);