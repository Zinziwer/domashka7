void FillArray2d(double[,] collection, int minValue = 0, int maxValue = 500)
{
    Random random = new Random();
    int rows = collection.GetLength(0);
    int columns = collection.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            collection[i, j] = Math.Round((new Random().NextDouble()) * (new Random().Next(minValue, maxValue)), 1);
        }
    }
}
void PrintArray2d(double[,] col)
{
    int rows = col.GetLength(0);
    int columns = col.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(col[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void FillArray2dd(int[,] collection, int minValue = 0, int maxValue = 500)
{
    Random random = new Random();
    int rows = collection.GetLength(0);
    int columns = collection.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            collection[i, j] = new Random().Next(minValue, maxValue);
        }
    }
}
void PrintArray2dd(int[,] col)
{
    int rows = col.GetLength(0);
    int columns = col.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(col[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int InputMessage(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void PrintArray(double[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write(col[i] + "\t");
    }
}
//Задача 47: Задайте двумерный массив размером m×n, заполненный
// случайными вещественными числами, округлёнными до одного знака.
void Zadacha47()
{
    Console.Clear();
    Random random = new Random();
    int rows = random.Next(3, 5);
    int columns = random.Next(3, 10);
    double[,] numbers = new double[rows, columns];
    FillArray2d(numbers, -20, 20);
    PrintArray2d(numbers);
}
//Zadacha47();

//Задача 50: Напишите программу, которая на вход принимает индексы
// элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
void Zadacha50()
{
    Console.Clear();
    Random random = new Random();
    int rows = random.Next(2, 7);
    int columns = random.Next(3, 8);
    int[,] numbers = new int[rows, columns];
    FillArray2dd(numbers, 3, 25);
    PrintArray2dd(numbers);
    int rowI = InputMessage("Enter a row index ");
    int columnJ = InputMessage("Enter a column index ");

    if (rowI <= rows && columnJ <= columns) Console.WriteLine($"The element [{rowI}, {columnJ}] is {numbers[rowI, columnJ]}");
    else Console.WriteLine("The element is not exist");
}
//Zadacha50();

//Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.
void Zadacha52()
{
    Console.Clear();
    Random random = new Random();
    int rows = random.Next(2, 7);
    int columns = random.Next(3, 10);
    int[,] numbers = new int[rows, columns];
    double[] sum = new double[columns];
    FillArray2dd(numbers, -20, 20);
    PrintArray2dd(numbers);
    Console.WriteLine();

    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            sum[i] += numbers[j, i];
        }
    }
    PrintArray(sum);
    Console.WriteLine();
    for (int i = 0; i < columns; i++)
    {
        Console.Write(Math.Round(sum[i]/rows, 2) + "\t");
    } 
}
Zadacha52();
