

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
//вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



int[,] matrix = new int[3,4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        //Console.Write($"{matrix[i, j]} ");
        matrix[i, j] = new Random().Next(-9, 9);
        Console.Write($"{matrix[i, j]} ");

    }
    Console.WriteLine();
}