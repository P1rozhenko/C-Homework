// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что 
// такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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

void LookForEl(int[,] matr)
{   Console.WriteLine($"Введите номер строки");
    int Si = Convert.ToInt32(Console.ReadLine());//search i
    Console.WriteLine($"Введите номер столбца");
     int Sj = Convert.ToInt32(Console.ReadLine());//search i


    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matrix GetValue (int[,] Si, Sj);//попытался воспользваться методом поиска элемента по справке майкрософт
        }
       Console.WriteLine(GetValue); 
    }

}



int[,] matrix = new int[3, 4];
//PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);
LookForEl(matrix);

