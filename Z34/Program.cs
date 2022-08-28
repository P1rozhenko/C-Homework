// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел 
// в массиве.
// [345, 897, 568, 234] -> 2




int[] arrayRandom = new int[4];
int ch = 0;//счетчик четных чисел в массиве
for (int i = 0; i < arrayRandom.Length; i++)
{
    arrayRandom[i] = new Random().Next(100, 999);
    Console.Write($"{arrayRandom[i]}  ");

    if (arrayRandom[i] % 2 == 0)
    {
        ch++;
    }
    
}
Console.WriteLine(ch);

