// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] SortRows(int[,] matrix)
{
    int maxIndex, temp;

    for (int k = 0; k < matrix.GetLength(0); k++)

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            maxIndex = i;

            for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[k, j] > matrix[k, maxIndex])
                {
                    maxIndex = j;
                }
            }

            temp = matrix[k, maxIndex];
            matrix[k, maxIndex] = matrix[k, i];
            matrix[k, i] = temp;
        }

    return matrix;
}


Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min value for element of matrix: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max value for element of matrix: ");
int maxVal = Convert.ToInt32(Console.ReadLine());
int[,] newArr = Create2dArray(rows, cols, minVal, maxVal);
Console.WriteLine("Изначальный массив: ");
Show2dArray(newArr);
Console.WriteLine("Сортированный: ");
newArr = SortRows(newArr);
Show2dArray(newArr);

*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int FindRowLowestSum(int[,] arr)
{
    int numRow = 0;
    int minSumRow = 0;
    int sumRow;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sumRow = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumRow += arr[i, j];
        }
        if (i == 0)
        {
            minSumRow = sumRow;
        }
        else if (sumRow < minSumRow)
        {
            minSumRow = sumRow;
            numRow = i;
        }

        Console.WriteLine($"{i}: {sumRow}");
        
    }
    Console.WriteLine();

    return numRow;
}

Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min value for element of matrix: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max value for element of matrix: ");
int maxVal = Convert.ToInt32(Console.ReadLine());
int[,] newArr = Create2dArray(rows, cols, minVal, maxVal);

Show2dArray(newArr);
Console.WriteLine($"Номер строки с минимальной суммой: {FindRowLowestSum(newArr)}");

*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MatrixMultiple(int[,] arrF, int[,] arrS)
{
    int[,] result = new int[arrF.GetLength(0), arrS.GetLength(1)];

    if (arrF.GetLength(1) != arrS.GetLength(0))
    {

        Console.WriteLine("Кол-во столбцов первого массива != кол-ву строк второго");

    }
    else
    {
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                for (int k = 0; k < arrS.GetLength(0); k++)
                {
                    result[i, j] += arrF[i, k] * arrS[k, j];
                }
            }
        }
    }
    return result;
}


Console.Write("Enter number of rows in first matrix: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns in first matrix: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of rows in second matrix: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns in second matrix: ");
int cols2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min value for element of matrix: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max value for element of matrix: ");
int maxVal = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = Create2dArray(rows, cols, minVal, maxVal);
Console.WriteLine("1-й массив: ");
Show2dArray(matrix1);
int[,] matrix2 = Create2dArray(rows2, cols2, minVal, maxVal);
Console.WriteLine("2-й массив: ");
Show2dArray(matrix2);
Console.WriteLine("Результат: ");
int[,] newArr = MatrixMultiple(matrix1, matrix2);
Show2dArray(newArr);

*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
//               добавляя индексы каждого элемента.

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

/*

int[,] Create2dSpiral(int rows, int cols)
{

    int[,] matrix = new int[rows, cols];
    
    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    int visits = cols;

    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[row, col] = i + 1;
        if (--visits == 0)
        {
            visits = cols * (dirChanges % 2) + rows * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }

        col += dx;
        row += dy;
    }
    return matrix;
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

Show2dArray(Create2dSpiral(5,3));

*/