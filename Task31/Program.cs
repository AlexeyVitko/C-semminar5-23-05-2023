﻿//31. 1. Задайте массив из 12 элементов,
// 2. заполненный случайными числами из промежутка [-9, 9]. 
// 3. Найдите сумму отрицательных и положительных элементов массива.

// 4. Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr, string sep) //sep - параметр для разделения (запятая и прочие)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

int[] GetSumPositiveNegativeElem(int[] arr)
{
    int sumPositive = 0;
    int sumNegetive = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            sumPositive += arr[i];
        else
            sumNegetive += arr[i];

    }
    return new int[2]{sumPositive, sumNegetive};
}

int GetSumPositiveElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int GetSumNegativeElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int[] array = CreateArrayRndInt(12, -9, 9);
Console.Write("[");
PrintArray(array, ",");
Console.WriteLine("]");

int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(array);
Console.WriteLine($"Сумма положительных элементов равна {sumPositiveNegativeElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов равна {sumPositiveNegativeElem[1]}");

int sumPositiveElem = GetSumPositiveElem(array);
int sumNegativeElem = GetSumNegativeElem(array);
Console.WriteLine($"Сумма положительных элементов равна {sumPositiveElem}");
Console.WriteLine($"Сумма отрицательных элементов равна {sumNegativeElem}");