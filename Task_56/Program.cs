Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите минимальное число в массиве: ");
int minValue = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите максимальное число в массиве: ");
int maxValue = int.Parse(Console.ReadLine() ?? "");
if (rows == columns)
    Console.WriteLine("Массив должен быть прямоугольным! Введите разное количество строк и столбцов.");
else
{
    int[,] array = GetArray(rows, columns, minValue, maxValue);
    PrintArray(array);

    Console.WriteLine();
    int minString = 0;
    int minSumString = SumStringElements(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        if (SumStringElements(array, i) < minSumString)
        {
            minSumString = SumStringElements(array, i);
            minString = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов {minString + 1}");
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int SumStringElements(int[,] arr, int i)
{
    int sumString = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sumString += arr[i, j];
    }
    return sumString;
}