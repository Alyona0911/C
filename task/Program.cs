// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// string [] FillArray ( string [] array1  )
// {
//     string [] array = new string [size] ;
//     for(int i = 0 ;i < size; i++)
//     {
//         array [i] = new Random().Next(start,finish+1) ;
//     }
//     return array1 ;
// }

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size  = GetInput("Введите массив строк: ");
string [] array1 = new string [size];
string [] array2 = new string [array1.Length] ;
// FillArray (array1) ;