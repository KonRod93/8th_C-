﻿/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[size, size];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= nums.GetLength(0) * nums.GetLength(1))
{
  nums[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < nums.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= nums.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > nums.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintArray(nums);

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
