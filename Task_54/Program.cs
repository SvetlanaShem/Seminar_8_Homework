Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите минимальное число в массиве: ");
int minValue = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите максимальное число в массиве: ");
int maxValue = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);

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
void SortArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = temp;
                }

            }
        }
    }
}