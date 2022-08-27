
// // Console.Clear();
// // string str1 = "Hello";
// // string str2 = "world";
// // //string str3 = string.Concat(str1, str2, "####");

// // int[] values = new int[] (1, 2, 3, 4, 5);
// // string str3 = string.Join("*", values);

// // Console.WriteLine(str3);

// //*********************

// // Console.Clear();
// // int[] arrayRandom = new int[12];

// // for (int i=0; i < arrayRandom.Length; i++);
// // {
// // arrayRandom[i] = new Random().Next(-9;10);
// // Console.Write($"{arrayRandom[i]}");
// // }

// // for (int i=0; i < arrayRandom.Length; i++);
// // {
// // if(arrayRandom[i] >= 0)
// // sumPositive += arrayRandom[i];
// // else


// // }


// //Создать массив из 123 чисел, и посчитать сколько и них
// // лежат в отрезке 10 - 99



// int[] arrayRandom = new int[123];

// for (int i = 0; i < 123; i++)
// {
//     arrayRandom[i] = new Random().Next(0, 300);
//     Console.Write(arrayRandom[i]);
//     Console.Write(" ");
// }
// Console.WriteLine(" ");
// int p = 0; //popalo

// for (int i = 0; i < 123; i++)
// {
//     if (arrayRandom[i] <= 99 && arrayRandom[i] >= 10)
//         p++;
// }
// Console.WriteLine(p);






// //***********


// //Найдите произведения пар чисел в одномерном массиве 


// int[] values = new int[] { 1, 2, 3, 4, 5 };
// int L = values.Length;
// if (values.Length % 2 == 1)

// int[] result = new int[L / 2+1];

// for (int i = 0; i < values.Length / 2; i++)

// {
//     result[i] = values[i] * values[-i];

// }
// if (values.Length % 2 == 1)

// result[i+1] = values [i+1];








//Задача 39: Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


int[] array = { 1, 3, 6, 8 };

int[] obratniy = new int[array.Length];

for (int i = 0; i < array.Length; i++)
{
    obratniy[i] = array[array.Length - 1 - i];

    Console.Write($"{obratniy[i]}  ");
}







// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// Console.WriteLine("Введите число A");

// int number = Convert.ToInt32(Console.ReadLine());

// int dvoichniy = 





