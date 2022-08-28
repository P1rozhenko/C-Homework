// Задача 38: Задайте массив вещественных чисел. Найдите 
// разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int[] arrayRandom = new int[4];
int max = 0;
int min = 0;
int dif = 0;
for (int i = 0; i < arrayRandom.Length; i++)
{
    arrayRandom[i] = new Random().Next(0, 99);
    Console.Write($"{arrayRandom[i]}  ");

    if (arrayRandom[i] > max)
    {
        max = arrayRandom[i];
    }
    if (arrayRandom[i] < min)
    {
        min = arrayRandom[i];
    }
    dif = max - min;
}
Console.WriteLine(dif);
