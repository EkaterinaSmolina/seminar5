// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// // Создание и вывод массива

// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int [N]; 
//     for (int i = 0; 1 < N; i++)
//     {
//     RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }



// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//     Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();

// }

// Console.Clear();
// Console.WriteLine(" Введите колличества элементов в массиве");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(" Введите первое число генерируемого диапазона");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(" Введите последнее число генерируемого диапазона");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myRandomArray = CreateRandomArray(num, min, max);
// ShowArray(myRandomArray);
// Console.WriteLine(" ------ ");
// // int[] myArray = CreateArray();
// // ShowArray(myArray);



// ДОМАШНЕЕ ЗАДАНИЕ


// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// int[] myArray = new int[4];
// Random rand = new Random();
// for (int x = 0; x < myArray.Length; x++)
//       {
//           myArray[x] = rand.Next(100,999);
//           Console.Write(myArray[x] + "  ");
//       }

// int result = 0;
// for (int i = 0; i < myArray.Length; i++)
// {
//     if(myArray[i]%2==0)
//     {
//         result++;
//     }
// }
// Console.WriteLine("-> " + result);



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] myArray = new int[5];
// Random rand = new Random();
// for (int x = 0; x < myArray.Length; x++)
//       {
//           myArray[x] = rand.Next(-99,99);
//           Console.Write(myArray[x] + "  ");
//       }

// int result = 0;
// for (int i = 0; i < myArray.Length; i++)
// {
//     if(i % 2 == 0)
//     {
//         result += myArray[i];
//     }
// }
// Console.WriteLine("сумма чисел на четных позициях  = " + result);







