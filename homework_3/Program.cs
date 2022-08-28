// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void palindrome(int num)
{

    num = Math.Abs(num);

    string strNum = num.ToString();

    int lenNum = strNum.Length;

    string secondNum = string.Empty;

    for (int i = 1; i <= lenNum; i++)
    {
        char dig = strNum[^i];
        secondNum += dig;
    }

    if (secondNum == strNum)
    {
        Console.WriteLine("Palindrome");
    }
    else
    {
        Console.WriteLine("Not a palindrome");
    }

}

System.Console.Write("Enter the number: ");

int number = Convert.ToInt32(Console.ReadLine());

palindrome(number);

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*

double lenSegment(double x1, double y1, double z1, double x2, double y2, double z2 )
{
    double dX = x1 - x2; 
    double dY = y1 - y2; 
    double dZ = z1 - z2;
    
    // double len = Math.Pow(dX * dX + dY * dY + dZ * dZ, 0.5);
    double len = Math.Sqrt(dX * dX + dY * dY + dZ * dZ);

    return len;
}


Console.Write("Enter the coordinate X of the first point: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y first point: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Z first point: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the coordinate X of the second point: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y second point: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Z second point: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"\n" + lenSegment(x1, y1, z1, x2, y2, z2));

*/
// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void cube(int num)
{
    if (num > 0)
    {
        for (int i = 1; i <= num; i++)
        {
            int result = Convert.ToInt32(i * i * i);

            Console.WriteLine($"{i}: {result}");
        }
    }
    else
    {
        Console.WriteLine($"\nEnter a positive number!");
    }

}

Console.Write("Enter the number: ");

int number = Convert.ToInt32(Console.ReadLine());

cube(number);

Console.WriteLine();
*/