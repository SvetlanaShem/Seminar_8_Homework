Console.Clear();
Console.Write("Введите размерность X в массиве: ");
int x = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите размерность Y в массиве: ");
int y = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите введите размерность Z в массиве: ");
int z = int.Parse(Console.ReadLine() ?? "");

int[,,] array = new int[x, y, z];
int[,,] array3D = FormArray(array);
PrintArray3D(array3D);


int[,,] FormArray(int[,,] arr)
{
    int[] temp = new int[arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2)];
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                }
            }
        }
    }
    int count = 0;
    for (int x = 0; x < arr.GetLength(0); x++)
    {
        for (int y = 0; y < arr.GetLength(1); y++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                arr[x, y, z] = temp[count];
                count++;
            }
        }
    }
    return arr;
}
void PrintArray3D(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}
