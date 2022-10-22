Console.Write("Введите номер четверти: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 0) {
    Console.Write("Нулевой четверти не существует");
}
else if (a > 0) {
    switch (a % 4) {
        case 0: {
            Console.Write($"{a} четверть содержит диапазоны x: [0; Infinity) и y: (-Infinity; 0]");
            break;
        }
        case 1: {
            Console.Write($"{a} четверть содержит диапазоны x: [0; Infinity) и y: [0; Infinity)");
            break;
        }
        case 2: {
            Console.Write($"{a} четверть содержит диапазоны x: (-Infinity; 0] и y: [0; Infinity)");
            break;
        }
        case 3: {
            Console.Write($"{a} четверть содержит диапазоны x: (-Infinity; 0] и y: (-Infinity; 0]");
        }
    }
}
else {
    switch (a % 4) {
        case 0: {
            Console.Write($"{a} четверть содержит диапазоны x: [0; Infinity) и y: [0; Infinity)");
            break;
        }
        case 1: {
            Console.Write($"{a} четверть содержит диапазоны x: [0; Infinity) и y: (-Infinity; 0]");
            break;
        }
        case 2: {
            Console.Write($"{a} четверть содержит диапазоны x: (-Infinity; 0] и y: (-Infinity; 0]");
            break;
        }
        case 4: {
            Console.Write($"{a} четверть содержит диапазоны x: (-Infinity; 0] и y: [0; Infinity)");
        }
    }
}