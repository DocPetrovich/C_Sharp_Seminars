﻿// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите цифру дня недели:");
string? answer = Console.ReadLine();
int number = Convert.ToInt32(answer);

if (number > 7 || number < 1)
{
    Console.WriteLine("Число должно быть от 1 до 7!");
}

if (number == 1) Console.WriteLine("Понедельник");
if (number == 2) Console.WriteLine("Вторник");
if (number == 3) Console.WriteLine("Среда");
if (number == 4) Console.WriteLine("Четверг");
if (number == 5) Console.WriteLine("Пятница");
if (number == 6) Console.WriteLine("Суббота");
if (number == 7) Console.WriteLine("Воскресенье");