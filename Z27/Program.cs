﻿// Задача 27: Напишите программу, которая принимает на вход 
//число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SummaCifer (int a)
{

    int sum = 0;
    while (a > 0)
    {
        sum = sum + a % 10;
        a = a / 10;
    }
    return sum;
}

Console.WriteLine(SummaCifer(5789));
