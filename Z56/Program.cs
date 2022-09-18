// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// // будет находить строку с наименьшей суммой элементов.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// // наименьшей суммой элементов: 1 строка

// int[,] matrix = new int[3, 4];

// void fillArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(0, 9);
//         }
//     }
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FindLeast(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         int k = 0 //строка с наименьшим
//         if ( Matrix[k])
        
//         Console.WriteLine();
//     }
// }


// fillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// SelectionSort(matrix);
// PrintArray(matrix);



void PrintArray(int[,] matr)

{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            Console.Write($"{matr[m, n]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)

{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            matr[m, n] = new Random().Next(1, 10);
        }
    }
}

int Sum(int[,] matr)
{
    int sum = 0;
    int minSum = 0;
    int minNum = 0;
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)

        {
            if (m == 0) //если строка первая
            {
                sum += matr[m, n];
                minSum += matr[m, n]; //по умолчанию считаем что сумма первой строки минимальная
            }

            else sum += matr[m, n]; //для всех остальных строк просто считаем сумму
        }

        if (sum < minSum)
        {
            minSum = sum; 
            minNum = m; 
        }
        sum = 0;         
    }
    return minNum;
}

int[,] matrix = new int[4, 4];

FillArray(matrix);

PrintArray(matrix);

Console.WriteLine();

Console.WriteLine(Sum(matrix));