/*Задача 54: Задайте двумерный массив. Напишите программу,
 которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

// Задаем параметры массива: длину, высоту, максимальные и минимальные значения чисел
Console.WriteLine("Enter amount of rows in matrix");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine(" Enter amount of columns in matrix");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter minimum limit of matrix ");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter maximum limit of matrix");
int max = int.Parse(Console.ReadLine()!);

// объясняем пользователю ошибку, которая возникнет, если он перепутает максимум и минимум
if (min>=max)
{
   Console.WriteLine(" Minimum should be less than maximum! Enter numbers correctly!"); 
   return;
}

int[,] matrix = Create2DArray(m, n, min, max);
Console.WriteLine();
Print2DArray(matrix);
ChangeRows(matrix);
Print2DArray(matrix);

int[,] Create2DArray(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


void ChangeRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Matrix Sorted from high to low!");
}


