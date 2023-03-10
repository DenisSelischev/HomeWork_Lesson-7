﻿//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int rows = Input("Введите индекс строки: ");
int colums = Input("Введите индекс столбца: ");
int[,] numbers = new int[6, 6];
FillArray(numbers);
PrintArray(numbers);

if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) 
        Console.WriteLine(numbers[rows, colums]);
else Console.WriteLine($"{rows}{colums} --> такого числа в массиве нет");

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
 
int Input(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}