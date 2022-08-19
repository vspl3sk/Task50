// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.Clear();

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3},");
            else Console.Write($"{array[i, j],3} ]");
        }
        Console.WriteLine();
    }
}

int[,] matrix = GetMatrix(3, 4);
PrintMatrix(matrix);

System.Console.WriteLine("Введите номер строки:");
int matrixRow = Convert.ToInt32(Console.ReadLine()) - 1;
System.Console.WriteLine("Введите номер столбца:");
int matrixColumn = Convert.ToInt32(Console.ReadLine()) - 1;

if (matrixRow < 0 | matrixRow > matrix.GetLength(0) - 1 | matrixColumn < 0 | matrixColumn > matrix.GetLength(1) - 1)
{
    Console.WriteLine("Элемент не существует");
}
else
{
    Console.WriteLine($"Значение элемента массива -> {matrix[matrixRow, matrixColumn]}");
}