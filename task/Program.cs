﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void SecondArray (string [] array1 )
{
   for( int i = 0; i < array1.Length; i++) ;
}




string [] array1 = new string[5] {"6746", "hi", "home", "world", "7685"};
string [] array2 = new string [array1.Length] ;
SecondArray ( array1 );
Console.Write($"  [{String.Join(",", array1)}]");