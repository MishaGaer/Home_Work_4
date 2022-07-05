/*
Напишите программу, 
которая задаёт массив из 8 элементов 
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
//рандомное заполнение массива
void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0, 500);
        index++;
    }
}
//Печать массива в консоль
void PrintArray(int[] array)
{
    int lenght = array.Length;
    lenght = lenght - 1;
    int position = 0;
    while (position < lenght)
    {
        Console.Write($"{array[position]}, ");
        position++;
    }
    Console.WriteLine($"{array[position]}");
}

//Основной код

int length = 8;
int[] collection = new int[length];

FillArray(collection);
PrintArray(collection);


