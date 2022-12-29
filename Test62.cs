/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


Console.WriteLine("Enter amount of rows and columns in matrix"); // вводим количество строк и колонок 
int Square = int.Parse(Console.ReadLine()!);                     // нашей квадратной матрицы

Console.WriteLine("Enter first number of matrix");                // вводим первое число матрицы
int FirstNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter step of increment in matrix");          // вводим шаг инкремента внутри матрицы
int Step = int.Parse(Console.ReadLine()!);

int[,] Matrix = Create2DArray( Square, Square);         // исполняемые функции
Print2DArray(Matrix);

int[,] Create2DArray(int m, int n)                   // Создаем матрицу
{
  int[,] Matrix = new int[m, n];
  int counter = 1;                             // эта переменная считает количетво итераций
  int i = 0;                                   // она не должна быть больше количества элементов в матрице
  int j = 0;

while (counter <= Matrix.GetLength(0) * Matrix.GetLength(1))
{
  Matrix[i, j] = FirstNumber;
  FirstNumber = FirstNumber + Step;
  counter ++;
  if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= Matrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > Matrix.GetLength(1) - 1)
    j--;
  else
    i--;
}
   return Matrix;
}

void Print2DArray(int[,] array)     //Выводим матрицу на печать
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




    
 



         
    







