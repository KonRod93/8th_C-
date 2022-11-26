/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int m = InputNumbers("Введите число строк 1-й матрицы:");
int n = InputNumbers("Введите число столбцов 1-й матрицы:");
int l = InputNumbers("Введите число строк 2-й матрицы:");
int k = InputNumbers("Введите число столбцов 2-й матрицы:");
int range = InputNumbers("Введите диапозон значений: от 1");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int[,] firstM = new int[m, n];
CreateArr(firstM);
Console.WriteLine($"Первая матрица");
PrintArray(firstM);

int[,] secondM = new int[l, k];
CreateArr(secondM);
Console.WriteLine($"Вторая матрица");
PrintArray(secondM);

int[,] resultM = new int[m, k];

MultipMatrix(firstM, secondM, resultM);
Console.WriteLine($"Произведение матриц");
PrintArray(resultM);

void MultipMatrix(int[,] firstM, int[,] secondM, int[,] resultM)
{
    for (int i = 0; i < resultM.GetLength(0); i++)
    {
        for (int j = 0; j < resultM.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstM.GetLength(1); k++)
            {
                sum = firstM[i, k] * secondM[k, j];
            }
            resultM[i, j] = sum;
        }
    }
}

void CreateArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}





