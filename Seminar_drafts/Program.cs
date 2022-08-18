
// void method1()
// {
//     Console.WriteLine("Pira");
// }
// method1();

// //type2

// void method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// method2(msg: "Message texxt");

//type2.1

// void method2(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         count++;
//     }
// }
// method21("Message texxt", 4);





//Напишите программу, кот принимает 
//число на вход число и выдает количество разрядов 

// int razryadnost (int R)
// {
// //Console.WriteLine("Введите число");
// //int N = Convert.ToInt32(Console.ReadLine());

// int i = 0;

// while (R > 0)
// {
//     R /= 10;
//     i++;
// }
// //Console.WriteLine(i);
// return i;
// }
// int B = razryadnost (12345999);
// Console.WriteLine(B);




//Принимаем на вход N и выдаем произведение чисел от 1 до N

// ulong fac(ulong R)

// {
//     ulong N = 1;
//     ulong i = 1;
//     while (i <= R)
//     {
//         N *= i;
//         i++;
//     }
//     return N;
// }
// Console.WriteLine(fac(21));



// Выводим массив из 8 чисел со случайными 0 и 1


int[] M = { 2, 3, 4, 5, 6, 7, 8, 9 };
int i = 0;

while (i < 8)
{
    M[i] = new Random().Next(0, 2);
    i++;
}
int i = 0;
for (i, i < 8, i++)
{
    Console.Write(M[i]);
}


