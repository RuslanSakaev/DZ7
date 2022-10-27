/*
Задача 52. 
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.WriteLine("Задайте двумерный массив из целых чисел: ");

int a = EnterSizeArray("Введите количество строк: ");
int b = EnterSizeArray("Введите количество столбцов: ");

int EnterSizeArray(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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

void ArithmeticMeanOfElements(int[,] CreateMatrixRndInt)
{
    int rows = CreateMatrixRndInt.GetLength(0);
    int cols = CreateMatrixRndInt.GetLength(1);

    for (int j = 0; j < rows; j++)
    {
        double colsAvg = 0;
        for (int i = 0; i < cols; i++)
        {                  
            colsAvg += CreateMatrixRndInt[i,j];
        }
        colsAvg = colsAvg / rows;
        
        Console.Write($" {colsAvg};");
    }
}

int[,] array2D = CreateMatrixRndInt(a, b, 0, 10);

PrintMatrix(array2D);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца: ");
ArithmeticMeanOfElements(array2D);
Console.WriteLine();

