/*
Задача 50. Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента 
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого элемента в массиве нет
*/
Console.WriteLine("Что бы узнать значение элемента в двумерном массиве ");

int a = EnteringAnArray("Введите индекс строки: ");
int b = EnteringAnArray("Введите индекс столбца: ");

int EnteringAnArray(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] array2D = CreateMatrixRndRealNum(3, 4, 0, 9);
Console.WriteLine();
PrintMatrix(array2D);

int[,] CreateMatrixRndRealNum(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - rows  0 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    if (a > matrix.GetLength(0) || b > matrix.GetLength(1))
    {
        Console.WriteLine("такого элемента в массиве нет");
    }
    else
    {
        Console.WriteLine($"в указанном ниже массиве значение {a} элемента строки и {b} столбца равно {matrix[a - 1, b - 1]}");
    }
    return matrix;

}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}




