﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int index = 1;

while (index <= num)
{
    Console.Write($"{Math.Pow(index, 3)}  ");
    index++;
}

// 1. Задаем число
// 2. Вводим счетчик цикла, начиная с 1, который будет показывать кубическое произведение себя и увеличиваться до заданного числа. 