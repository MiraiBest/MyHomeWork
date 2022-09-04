// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int degree(int firstNum, int secondNum)
{
    int degreeNum = 1;

    if (secondNum == 0)
        return degreeNum;
    else if (secondNum == 1)
        return firstNum;
    else
    {
        for (int i = 1; i <= secondNum; i++)        
        {
            degreeNum *= firstNum; 
        }
        
        return degreeNum;
    }

}

Console.Write("Введите числое, которое хотите возвести в степень: ");
int fNum = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите степень в которую хотите возвести {fNum}: ");
int sNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{fNum} в степени {sNum} = {degree(fNum, sNum)}");

*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
void sumNumbers(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }

    Console.WriteLine($"Сумма чисел равна: {sum}");
}


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
sumNumbers(num);
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*

int[] createArray(int len, int min, int max)
{
    int[] array = new int[len];

    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void printArray(int[] pArray)
{
    Console.Write("[");

    for (int i = 0; i < pArray.Length; i++)
    {
        Console.Write($"{pArray[i]}, ");
    }

    Console.Write("\b\b]");
    Console.WriteLine();
}

printArray(createArray(8, 1, 200));

Console.WriteLine($"[{string.Join(", ", createArray(8,2,45))}]");

*/