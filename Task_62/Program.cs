Console.Clear();
Console.WriteLine("Заполнение массива 4 на 4 спиралью");
int[,] array = CreatSpiralArray(4);
PrintArray(array);

int[,] CreatSpiralArray(int size)
{
    int[,] arr = new int[size, size];
    int count = 1;
    int i = 0;
    int j = 0;
    while (count <= size * size)
    {
        arr[i, j] = count;
        count++;
        if (i <= j + 1 && i + j < size - 1)
            j++;
        else if (i < j && i + j >= size - 1)
            i++;
        else if (i >= j && i + j > size - 1)
            j--;
        else
            i--;
    }
    return arr;
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
