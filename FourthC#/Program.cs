﻿/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. */
/*
int ToDegree(int a, int b)

 {
    int count = 1;
    int res = 1;
    while(count <= b)
    {
        res *= a;
        count++;
    }
    return res;
 }

Console.Write("Input a Number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a Degree: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = ToDegree(a, b);
Console.Write(result);
*/



/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. */
/*
int NumberSum(int num)
{
    int sum = 0;
    for(int element = 0; num > 0; element++)
    {
        element = num % 10;
        num = num / 10;
        sum += element;
    }
    return sum;
}

Console.Write("Input a Number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = NumberSum(num);
Console.Write($"The Sum of the elements of Number {num} is {result}");
*/



/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. */
/*
int[] CreateArray(int length)
{
    int[] array = new int[length];

    for(int i = 0; i < length; i++)
    {
        Console.Write($"Input Value of {i + 1} element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int []array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
}

Console.Write("Input the Array size: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(length);
ShowArray(myArray);
*/