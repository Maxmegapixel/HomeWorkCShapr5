﻿/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3, 4, 1, 77, 65] => 77 - 1 = 76
*/

int[] Array = GetArray(6, -10, 10);
Console.WriteLine($"[{String.Join(',', Array)}]");
int sum = GetSum(Array);
Console.WriteLine($"Сумма элементов на нечётных индексах: {sum}");

int[] GetArray(int size, int MinVal, int MaxVal)
{
    int[] Array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(MinVal, MaxVal + 1);
    }
    return Array;
}
int GetSum(int[] Array)
{
    int summ = 0;
    for (int i = 1; i < Array.Length; i += 2)
    {
        summ += Array[i];
    }
    return summ;
}

