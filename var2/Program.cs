/*Задача 30: Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/

void arrayZero(int[] col) // здесь мы задаем первый массив
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write ($"Введите {i} элемент массива: ");
        col[i] = int.Parse(Console.ReadLine()!);
    }
}
void printArray(int[] col) // мы выводим в терминале массив
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write($"{col[i]} ");
    }
}
int[] arrayDuble(int[] col) // мы копируем массив
{
    int[] facto = new int[col.Length];
    for (int i = 0; i < facto.Length; i++)
    {
       facto[i] = col[i] * 2; //мы решили удвоить скопированный массив (просто из интереса)  
    }
    return facto;
}
int[] array = new int[5]; // создаем "0" массив длиной 3 (переменную количества элементов программист задает сам)
arrayZero(array); // вызываем метод для ввведения переменных значений в терминале 
printArray(array); // вызывается метод для вывода массива
Console.WriteLine (); // переход на новую строку
int[] collection = arrayDuble(array); // вызываем метод для копирования массива
printArray(collection); // вызывается метод для вывода копии массива