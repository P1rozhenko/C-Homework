// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот 
// день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели");
int N = Convert.ToInt32(Console.ReadLine());
if ((N == 6) || (N == 7))
{
    Console.WriteLine("Да, является выходным");
}
else
     Console.WriteLine("Нет, не является выходным");

