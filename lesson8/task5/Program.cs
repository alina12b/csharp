void WriteArr(string[,] arr) {
    int rows = arr.GetUpperBound(0) + 1;
    int columns = arr.Length / rows;

    int i = 0;
    while (i < rows) {
        int j = 0;
        while (j < columns) {
            Console.Write($"{arr[i, j]} ");
            j++;
        }
        Console.WriteLine();
        i++;
    }
    Console.WriteLine();
    return;
}

string[,] CreateRoundingArr(int m) {
    string[,] arr = new string[m, m];
    int rows = arr.GetUpperBound(0) + 1;
    int topRow = 1;
    int columns = arr.Length / rows;
    int leftColumn = 0;
    int i = 0;
    int j = 0;
    bool incI = true;
    bool incJ = true;
    string currIndex = "j";

    for(int count = 1; count <= arr.Length; count++) {
        arr[i, j] = count < 10 ? $"0{count}" : $"{count}";
        if (currIndex == "i") {
            if (incI) {
                i++;
                if (i == rows - 1) {
                    currIndex = "j";
                    incI = !incI;
                    rows--;
                }
            } else {
                i--;
                if (i == topRow) {
                    currIndex = "j";
                    incI = !incI;
                    topRow++;
                }
            }
        } else {
            if (incJ) {
                j++;
                if (j == columns - 1) {
                    currIndex = "i";
                    incJ = !incJ;
                    columns--;
                }
            } else {
                j--;
                if (j == leftColumn) {
                    currIndex = "i";
                    incJ = !incJ;
                    leftColumn++;
                }
            }
        }
    }

    return arr;
}

string[,] arr = CreateRoundingArr(4);

WriteArr(arr);