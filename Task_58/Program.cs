Console.Clear();
Console.Write("Введите количество строк в первом массиве: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов в первом массиве и количество строк во втором массиве: ");
int columnsAndRows2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов во втором массиве: ");
int columns2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите минимальное число в первом массиве: ");
int minValue = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите максимальное число в первом массиве: ");
int maxValue = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите минимальное число во втором массиве: ");
int minValue2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите максимальное число во втором массиве: ");
int maxValue2 = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columnsAndRows2, minValue, maxValue);
int[,] array2 = GetArray(columnsAndRows2, columns2, minValue2, maxValue2);
PrintArray(array);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
int[,] arrayProd = GetMatrixProd(array, array2);
Console.WriteLine("Произведение двух матриц:");
PrintArray(arrayProd);

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

int[,] GetMatrixProd(int[,] arr, int[,] arr2)
{
    int[,] arrProd = new int[arr.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                arrProd[i, j] += arr[i, k] * arr2[k, j];
            }
        }
    }
    return arrProd;
}