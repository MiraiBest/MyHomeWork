// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*

void searchSecondDigit(int number)
{
    int maxSizeNumber = 3;
    int secondDigit;

    string numberToStr = number.ToString();
    
    int numLen = numberToStr.Length;
    
    if (numLen == maxSizeNumber)
    {

        secondDigit = (Convert.ToInt32(number) / 10) % 10;
        Console.WriteLine($"Вторая цифра числа {number} --> {secondDigit}");

    }
    else
    {
        Console.WriteLine("Число не трехзначное");
    }
}

System.Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();

searchSecondDigit(number);

*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
void searchThirdDigit(int number)
{
    int minSizeNumber = 3,
        findIndex = 2;
    
    string numberToStr = number.ToString();
    
    int numLen = numberToStr.Length;
    
    if (numLen >= minSizeNumber)
    {
        char thirdDigit = numberToStr[findIndex];
        Console.WriteLine($"Третья цифра числа {number} --> {thirdDigit}");
    }
    else
    {
        Console.WriteLine($"У числа {number} нет третьей цифры");
    }
}

System.Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();

searchThirdDigit(number);

*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
void searchDay(int number)
{
    
    if (number <= 5)
    {
        Console.WriteLine($"Будний");
    }
    else if (number > 5 && number <= 7)
    {
        Console.WriteLine($"Выходной");
    }
    else 
    {
        System.Console.WriteLine("Данное число не обозначает день недели");
    }
}

System.Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();

searchDay(number);

*/