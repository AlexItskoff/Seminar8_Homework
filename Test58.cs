/*Задача 58: Задайте две матрицы. Напишите программу,
 которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int m = 2;  // программа для простоты работает только с матрицами 2*2
int n = 2;


Console.WriteLine("Enter minimum limit of matrix 1");
int min1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter maximum limit of matrix 1");
int max1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter minimum limit of matrix 2");
int min2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter maximum limit of matrix 2"); 
int max2 = int.Parse(Console.ReadLine()!);

// объясняем пользователю ошибку, которая возникнет, если он перепутает максимум и минимум
if (min1 >= max1 || min2 >= max2)
{
   Console.WriteLine(" Minimum should be less than maximum! Enter numbers correctly!"); 
   return;
}

int [,]  matrix1 = Create2DArray( m, n,  min1,  max1);
int [,]  matrix2 = Create2DArray( m, n,  min2,  max2);
int [,]  matrix3 = Create2DMultipliedArray(m,n);

Console.WriteLine();
Console.WriteLine("Matrix 1");
Print2DArray(matrix1);
Console.WriteLine();
Console.WriteLine("Matrix 2");
Print2DArray(matrix2);
Console.WriteLine();
Console.WriteLine("Matrix 1 * Matrix 2");
Print2DArray(matrix3);





int[,] Create2DArray(int m, int n, int min, int max)   // Создаем исходные матрицы
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

 //вручную прописываем матрицу - произведение двух исходных матриц
int[,] Create2DMultipliedArray(int m, int n)    
{
    int[,] matrix3 = new int[m, n];
 
    matrix3[0,0] = matrix1[0,0]*matrix2[0,0]+matrix1[0,1]*matrix2[1,0];
    matrix3[0,1] = matrix1[0,0]*matrix2[0,1]+matrix1[0,1]*matrix2[1,1];
    matrix3[1,0] = matrix1[1,0]*matrix2[0,0]+matrix1[1,1]*matrix2[1,0];
    matrix3[1,1] = matrix1[1,0]*matrix2[0,1]+matrix1[1,1]*matrix2[1,1];

    return matrix3;
}