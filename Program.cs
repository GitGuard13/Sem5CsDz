// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int [] array = new int [10];
// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 1000);
// }

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         count++;
        
//     }
// }
// Console.Write($"[{String.Join(", ",array)}] -> {count}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int [] array = new int [9];
// int numberSum = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-100, 100);
// }

// for (int i = 0; i < array.Length; i++)
// {
//     if (i % 2 != 0  && array[i] > 0)
//     {
//         numberSum += array[i];
//     }
// }    
// Console.WriteLine($"[{String.Join(", ", array)}] -> {numberSum}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// double [] array = new double[7];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Math.Round(new Random().NextDouble() * 100, 2);   
// }

// double max = array[0];
// double min = array[0];

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] < min)
//         min = array[i];
//     if (max < array[i])
//         max = array[i]; 
// }

// Console.WriteLine($"[{String.Join("  ", array)}] -> {Math.Round(max - min, 2)}");