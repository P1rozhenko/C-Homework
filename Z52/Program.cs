// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            //Console.Write($"{matrix[i, j]} ");
            //matrix[i, j] = new Random().Next(-9, 9);
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-9, 9);
        }
    
    }

}

void Srednee(int[,] matr)
int sr = 0
{   for (int i = 0; i < matr.GetLength(0); i++)
    {
        sr = (int[i]+//не понимаю как посчитать среднее
    }

}



int[,] matrix = new int[3, 4];
//PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);
LookForEl(matrix);

