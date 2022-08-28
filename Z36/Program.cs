// Задача 36: Задайте одномерный массив, заполненный
//  случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arrayRandom = new int[4];
int sum = 0;//сумма чисел в нечетных позициях
for (int i = 0; i < arrayRandom.Length; i++)
{
    arrayRandom[i] = new Random().Next(-99, 99);
    Console.Write($"{arrayRandom[i]}  ");

    if (i % 2 == 1)
    {
        sum+=arrayRandom[i];
    } 
}
Console.WriteLine(sum);
