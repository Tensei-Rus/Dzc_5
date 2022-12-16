// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.

// [3 7 22 2 78] -> 76

using static System.Console;
Write("Введите размер массива: ");
int length=int.Parse(ReadLine()!);
Write("Введите минимальное значение массива: ");
int min=int.Parse(ReadLine()!);
Write("Введите максимальное значение массива: ");
int max=int.Parse(ReadLine()!);

int[] Array= GetArray(length, min, max);
WriteLine($"[{string.Join(", ", Array)}]"); 

FindDifference(Array, max, min);
int[] GetArray(int size, int minValue, int maxValue)
{
    Random num = new Random();
    int[] result= new int[size];
    for(int i= 0; i< result.Length; i++)
    {result[i] = num.Next(minValue, maxValue+ 1);
    }
    return result;
}
void FindDifference(int[] MyArray, int minVal, int maxVal)
{
    for(int i= 0; i< MyArray.Length; i++)
   {
        if(MyArray[i] < minVal)
        {
           minVal=MyArray[i];
       }
       if(MyArray[i] > maxVal)
       {
           maxVal=MyArray[i];
       }
    }
    WriteLine($"Разница {maxVal-minVal}");
 }