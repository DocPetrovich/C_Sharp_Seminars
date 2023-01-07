﻿// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int arraySize = 2;

int[,,] array = new int[2, 2, 2];

int[] arr = new int[2 * 2 * 2];

int temp;
for(int i = 0;i < arr.Length;i++)
    {
    while(arr[i] == 0)
        {
        temp = new Random().Next(10, 100);
        if(Array.IndexOf(arr, temp, i) == -1)
            {
            arr[i] = temp;
            }
        }
    }

int count = 0;

for(int arrayN1 = 0;arrayN1 < arraySize;arrayN1++)
    {
    for(int arrayN2 = 0;arrayN2 < arraySize;arrayN2++)
        {
        Console.WriteLine();
        for(int arrayN3 = 0;arrayN3 < arraySize;arrayN3++)
            {
            array[arrayN1, arrayN2, arrayN3] = arr[count];
            count++;
            Console.Write($"{array[arrayN1, arrayN2, arrayN3]} ({arrayN1},{arrayN2},{arrayN3})  ");
            }
        }
    }

Console.ReadKey();