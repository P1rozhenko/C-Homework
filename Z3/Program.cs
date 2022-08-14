// Задача 6: Напишите программу, которая 
// на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int ostatok = 0;

ostatok = num % 2;

if (ostatok == 0)
{
    Console.WriteLine("Введено четное число");
}
else
    Console.WriteLine("Введено нечетное число");
