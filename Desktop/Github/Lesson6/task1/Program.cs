﻿﻿// Создать двумерный массив с размерами
// 3 х 5, состоящий из целых чисел
// Вывести его элементы на экран

// int[,] matrix = new int [3,5];
// Random rnd = new Random();
// for(int i = 0; i < matrix.GetLength(0); i++)
// {
//     for(int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = rnd.Next(1, 11);
//     }
// }

// for(int i = 0; i < matrix.GetLength(0); i++)
// {
//     for(int j = 0; j < matrix.GetLength(1); j++)
//     {
//         System.Console.Write($"{matrix[i,j]} "); // такой вывод называется интерполяция строк
//     }
//     System.Console.WriteLine();
// }

// вывод в виде функции (которая сформирует дввумерный массив из случайных целых чисел)
int [,] CreateMatrix (int rowCount, int colomsCount)
{
int[,] matrix = new int[rowCount,colomsCount];
Random rnd = new Random();
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = rnd.Next(1, 11);
    }
}
return matrix;
}
void ShowMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        System.Console.Write($"{matrix[i,j]} "); // такой вывод называется интерполяция строк
    }
    System.Console.WriteLine();
}
}
int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);