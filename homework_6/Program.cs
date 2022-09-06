// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*

int[] createArray(int len)
{

    int[] arr = new int[len];

    for (int i = 0; i < len; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");

        arr[i] = Convert.ToInt32(Console.ReadLine());

    }

    Console.WriteLine("[{0}]", string.Join(", ", arr));

    return arr;
}

void findPositiv(int[] arr)
{
    int j = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            j++;        
        }
    }

    Console.WriteLine($"Кол-во элементов массива больше 0: {j}");
}

Console.Write("Введите длину массива, которую хотите ввести: ");

int lenArr = Convert.ToInt32(Console.ReadLine());

findPositiv(createArray(lenArr));

*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//            заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)