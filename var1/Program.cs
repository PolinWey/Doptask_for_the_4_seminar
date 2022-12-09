/*Задача 30: Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/


/*int[] arrayZero(int[] col)
{
    int[] facto = col;
    //Console.WriteLine ("Введите элементы массива: ");
    for (int i = 0; i < facto.Length; i++)
    {
        Console.Write ($"Введите {i} элемент массива: ");
        facto[i] = int.Parse(Console.ReadLine()!);
    }
    return facto;
}*/
void arrayZero(int[] col)
{
    //Console.WriteLine ("Введите элементы массива: ");
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write ($"Введите {i} элемент массива: ");
        col[i] = int.Parse(Console.ReadLine()!);
    }
}
void printArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write($"{col[i]} ");
    }
}
int[] array = new int[3];
//array = arrayZero(array);
arrayZero(array);
printArray(array);
Console.WriteLine ();
int[] collection = array;
printArray(collection);