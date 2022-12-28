/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
 которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
Console.WriteLine();
NumberRowMinSumElements(matrix);


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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}


void  NumberRowMinSumElements(int[,] matrix)   //Процедура для подсчета мин. суммы в рядах и номера ряда
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minRow += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sumRow += matrix[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.WriteLine($"{minRow} - min summa in rows");
    Console.Write($"{minSumRow + 1}th row has lowest summa");
    
}