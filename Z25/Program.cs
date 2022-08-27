// Задача 25: Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int vozvedenie (int a, int b)
{

    for (int i = 1; i < b; i++)
    {
        a = a * a;
    }
    return a;
}
 Console.WriteLine(vozvedenie (2, 3));