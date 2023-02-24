﻿void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index +1;
        index++;
    }
}
// void метод не возвращает, return не используется
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //Создай новый массив, в котором 10 элементов
FillArray(array);         // Заполнил массив
PrintArray(array);        // Распечатал массив 
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);