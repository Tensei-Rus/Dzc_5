// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
using static System.Console;
Write("Введите размер массива: ");
int length =int.Parse(ReadLine()!);
Write("Введите минимальное значение массива: ");
int min=int.Parse(ReadLine()!);
Write("Введите максимальное значение массива: ");
int max=int.Parse(ReadLine()!);

int[] Array= GetArray(length, min, max);
WriteLine($"[{string.Join(", ", Array)}]");
MyArray(Array);

int[] GetArray(int size, int minValue, int maxValue)
{
    Random arr= new Random(); 
    int[] result= new int[size];
    for(int i= 0; i< result.Length; i++)
    {
        result[i] = arr.Next(minValue, maxValue+ 1);
    }
    return result;
}
void MyArray(int[] MyArray)
{
    int sum=0;
    for(int i= 1; i< MyArray.Length; i=i+2)
    {
    sum = sum + MyArray[i];
    }   
    WriteLine($"Сумма чисел на нечётных позициях : {sum}");
}
