// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//            Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

void findPositiv (int[] arr)
{

    int len = arr.Length,
        j = 0;

    Console.WriteLine("[{0}]", string.Join(", ", arr));

    for (int i = 0; i < len; i++)
    {
        if (arr[i] % 2 == 0)
        {
            j++;
        }
        
    }

    if (j != 0)
    {
       Console.WriteLine($"В массиве положительных чисел --> {j} "); 
    }
    else
    {
        Console.WriteLine("Нет положительных чисел");
    }

    
}

findPositiv(createArray(16, 100, 999));

*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

void findSumOddPos(int[] arr)
{
    int sum = 0;

    Console.WriteLine("[{0}]", string.Join(", ", arr));

    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    
    Console.WriteLine($"Сумма чисел на отрицательный позициях равна: {sum}");
}

findSumOddPos(createArray(100, 1, 10));

*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

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

void findDiff(int[] arr)
{
    int min = arr[0],
        max = arr[1],
        diff = 0;

    Console.WriteLine("[{0}]", string.Join(", ", arr));

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
        
        if (arr[i] > max)
        {
            max = arr[i];            
        }
    } 

    Console.WriteLine($"Разница между максимальным: {max}, и минимальным {min} = {diff = max - min}");

}

findDiff(createArray(4, -10, 5));

*/