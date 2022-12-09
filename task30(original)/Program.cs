/*Задача 30 (ИСХОДНАЯ): Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/

void arrayZero(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(0, 2);
    }
}
void printArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write($"{col[i]} ");
    }
}
int[] array = new int[8];
arrayZero(array);
printArray(array);