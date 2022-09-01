



// // // //Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет 
// // // местами первую и последнюю строку массива.

// // int m = new Random().Next(1, 10);
// // int n = new Random().Next(1, 10);
// // int[,] num = new int[m, n];
// // for (int i = 0; i < num.GetLength(0); i++)
// // {
// //     for (int j = 0; j < num.GetLength(1); j++)
// //     {
// //         num[i, j] = new Random().Next(1, 10);
// //         Console.Write($"{num[i, j]} ");
// //     }
// //     Console.WriteLine();
// // }
// //     Console.WriteLine("Массив с измененными строками");
// // for (int j = 0; j< num.GetLength(1); j++)
    
// //     {
// //         int current = num[0, j]; 
// //         num[0, j] = num[num.GetLength(0) - 1, j]; 
// //         num[num.GetLength(0) - 1, j] = current;
        
// //     }

// // for (int i = 0; i < num.GetLength(0); i++)
// // {
// //     for (int j = 0; j < num.GetLength(1); j++)
// //     {
// //         Console.Write($"{num[i, j]} ");
// //     }
// //     Console.WriteLine();
// // }








// // Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки 
// // на столбцы. В случае, если это невозможно, программа должна вывести сообщение 
// // для пользователя.

// int m = new Random().Next(1, 10);
// int n = new Random().Next(1, 10);
// int[,] num = new int[m, n];
// for (int i = 0; i < num.GetLength(0); i++)
// {
//     for (int j = 0; j < num.GetLength(1); j++)
//     {
//         num[i, j] = new Random().Next(1, 10);
//         Console.Write($"{num[i, j]} ");
//     }
//     Console.WriteLine();
// }


// int[,] array = new int[n, m];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = num[j, i];
//         Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
// }





//59 составить частотный словарь элементов двумерного массива



int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);

int[,] num = new int[m, n];
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = new Random().Next(1, 10);
        Console.Write($"{num[i, j]} ");

    }
    Console.WriteLine();
}

int[,] chast = new int[(m*n), 2];

int count = 0;

for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
       for (int g = 0; g < (m * n); g++)
       {
        if (num[i, j]==chast[g, 0])
        {
            [g, 1]++
        }
       }
    }
}