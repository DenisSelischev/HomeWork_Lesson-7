//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] numbers = new int[n, m];

FillArray(numbers);


for (int i = 0; i < numbers.GetLength(0); i++)
{
    double avarage = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write($"{Math.Round(avarage,2)}; ");
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("]");
        
        
    }
}

PrintArray(numbers);