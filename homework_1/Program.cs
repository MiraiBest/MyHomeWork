//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
int numFirst,
    numSecond,
    maxNum,
    minNum;

Console.Write("Введите первое число: ");

numFirst = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");

numSecond = Convert.ToInt32(Console.ReadLine());

if (numFirst > numSecond )
{
    maxNum = numFirst;
    minNum = numSecond;
}
else
{
    maxNum = numSecond;
    minNum = numFirst;
}

Console.WriteLine($"Максимальное число: {maxNum}\nМинимальное число: {minNum}");
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
int numFirst,
    numSecond,
    numThird,
    maxNum = 0;

Console.Write("Введите первое число: ");

numFirst = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");

numSecond = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");

numThird = Convert.ToInt32(Console.ReadLine());

if (numFirst > numSecond && numFirst > numThird)
{
    maxNum = numFirst;
}
else if (numSecond > numFirst && numSecond > numThird)
{
    maxNum = numSecond;
}
else if (numThird > numFirst && numThird > numSecond)
{
    maxNum = numThird;
}

Console.WriteLine($"Max number is: {maxNum}");
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
int number;

Console.Write("Введите число: ");

number = Convert.ToInt32(Console.ReadLine());

number = number % 2;

if (number == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}
*/


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
int number,
    current = 2;

Console.Write("Введите число: ");

number = Convert.ToInt32(Console.ReadLine());

while (current < number)
{
    Console.Write($"{current}, ");
    current += 2;
} 

*/
