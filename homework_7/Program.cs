
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
double[,] CreateRandomDoubleMatrix()
{
    Console.Write("Enter number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number of columns: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter min value for element of matrix: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter max value for element of matrix: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    double[,] arr = new double[rows, cols];
    Random rng = new Random();
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            arr[i, j] = rng.Next(minVal, maxVal) + rng.NextDouble();
    return arr;
}

void PrintDoubleMatrix(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]:f2}" + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


PrintDoubleMatrix(CreateRandomDoubleMatrix());

*/


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//                  и возвращает значение этого элемента или же указание, что такого элемента нет.

/*

int[,] Create2dArray(int rows, int cols, int minValue, int maxValue)
{

    int[,] newArray = new int[rows, cols];

    for (int i = 0; i < rows; i++)

        for (int j = 0; j < cols; j++)

            newArray[i, j] = new Random().Next(minValue, maxValue + 1);


    return newArray;
}

void Show2dArray(int[,] arr)
{
    Console.WriteLine();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

string GetElementByPos(int[,] matrix, int row, int col)
{
    if (matrix.GetLength(0) > row && matrix.GetLength(1) > col)
        return Convert.ToString(matrix[row, col]);
    else
        return ("отсутствует");
}

Console.Write("Input the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());


// Show2dArray(Create2dArray(rows, cols, minValue, maxValue));
int[,] newArr = Create2dArray(rows, cols, minValue, maxValue);
Show2dArray(newArr);
Console.Write($"Enter row for search[0..{rows - 1}]:  ");
int rowNum = Convert.ToInt32(Console.ReadLine());
Console.Write($"Enter column for search[0..{cols - 1}]:  ");
int colNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Элемент в позиции [{rowNum}, {colNum}] {GetElementByPos(newArr, rowNum, colNum)}");

*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*

int[,] Create2dArray(int rows, int cols, int minValue, int maxValue)
{

    int[,] newArray = new int[rows, cols];

    for (int i = 0; i < rows; i++)

        for (int j = 0; j < cols; j++)

            newArray[i, j] = new Random().Next(minValue, maxValue + 1);


    return newArray;
}

void Show2dArray(int[,] arr)
{
    Console.WriteLine();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintDoubleMatrix(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]:f2}" + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] FindColumnMeans(int[,] matrix)
{
    double sum;
    int len = matrix.GetLength(0);
    double[,] mean = new double[1, matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }
        mean[0, i] = sum / len;
    }
    return mean;
}

Console.Write("Input the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] newArr = Create2dArray(rows, cols, minValue, maxValue);
Show2dArray(newArr);
Console.WriteLine("Средние арифметические элементов по столбцам:");
PrintDoubleMatrix(FindColumnMeans(newArr));

*/