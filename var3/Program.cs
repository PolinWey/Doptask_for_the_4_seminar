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
       facto[i] = col[i]; //мы решили удвоить скопированный массив (просто из интереса)  
    }
    return facto;
}
int[] arrayMnogo(int[] col1, int [] col2) // мы перемножаем два предыдущих массива
{
    int[] sambo = new int[col1.Length];
    for (int i = 0; i < sambo.Length; i++)
    {
       sambo[i] = col1[i] * col2[i];  
    }
    return sambo;
}
Console.Write("Задайте длину массива: ");
int length = int.Parse(Console.ReadLine()!);
int[] array = new int[length];  // создаем "0" массив длиной 3 (переменную количества элементов программист задает сам)
arrayZero(array); // вызываем метод для ввведения переменных значений в терминале 
printArray(array); // вызывается метод для вывода массива
Console.WriteLine (); // переход на новую строку
int[] collection = arrayDuble(array); // вызываем метод для копирования массива
printArray(collection); // вызывается метод для вывода копии массива
int[] samb = arrayMnogo(collection, array);
Console.WriteLine ();
printArray(samb);

// Здесь мы решили:
// 1. позволить пользователю самому задавать длину массива
// 2. добавить еще один массив, в котором будут переммножаться первый и второй массивы и выводится на экран  