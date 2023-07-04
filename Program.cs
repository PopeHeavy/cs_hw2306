/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */


// int[] RandomArray(int size, int minVal, int maxVal)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(minVal, maxVal);
//     }

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     return array;
// }

// int EvenCount(int[] arr)
// {
//     int even = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i]%2 == 0) even++;
//     }
//     return even;
// }

// int[] array1 = RandomArray(new Random().Next(10, 20), 100, 999+1);

// Console.WriteLine($"Even numbers in the array: {EvenCount(array1)}");

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

// int[] RandomArray(int size, int minVal, int maxVal)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(minVal, maxVal);
//     }

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     return array;
// }

// int OddSum(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i+=2)
//     {
//         sum += arr[i];
//     }
//     return sum;
// }

// int[] array2 = RandomArray(5, -500, 500);

// Console.WriteLine($"Sum of numbers with odd index {OddSum(array2)}");

// /* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */


// double[] array = new double[5];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Math.Round(new Random().NextDouble(), 2) + new Random().Next(-500, 500);
// }

// for (int i = 0; i < array.Length; i++)
//     Console.Write(array[i] + " ");


// double min = array[0];
// double max = array[0];
// for (int i = 1; i < array.Length; i++)
// {
//     if (array[i] > max) max = array[i];
//     else if (array[i] < min) min = array[i];
// }
// Console.WriteLine($" {max} - {min} = {max - min}");