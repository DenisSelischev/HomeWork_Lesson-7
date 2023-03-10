//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int rows = Input("Введите количество строк: ");
int colums = Input("Введите количество столбцов: ");
double[,] numbers = new double[rows, colums];
FillArray(numbers);
PrintArray(numbers);

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 10.0;
        }
    }
}

void PrintArray(double[,] array)
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