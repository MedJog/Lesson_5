// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int[] array = new int[10]; // Создание нового массива
void FillArray(int[] collection) // Заполнение массива случайными числами
{
    int length = collection.Length; // определение длины массива
    int index = 0;
    while (index < length)
     {
     collection[index] = new Random().Next(1, 20); 
     index++; 
    }
}
void PrintArray(int[] col) // вывод элементов массива на экран
{
    int count = col.Length;
    int position = 0;
    while (position < count)
     {
     Console.Write($"{col[position]} ");
      position++;
    }
}
 
 int MaxNum(int[] coll) // Функция поиска максимального элемента массива
 {
    int N = coll.Length;
    int index = 0;
    int max = coll[index];
    while (index < N)
    {
        if ( coll[index] > max)
        {
            max = coll[index];
        }
    index++;
    }
    return max;
 }
 int MinNum(int[] coll) // Функция поиска минимального элемента массива
 {
    int N = coll.Length;
    int index = 0;
    int min = coll[index];
    while (index < N)
    {
        if ( coll[index] < min)
        {
            min = coll[index];
        }
    index++;
    }
    return min;
 }
 
 FillArray(array);
 PrintArray(array);
 Console.WriteLine();
int Max = MaxNum(array);
Console.WriteLine($"Максимальный элемент массива - {Max}");
int Min = MinNum(array);
Console.WriteLine($"Минимальный элемент массива - {Min}");
int Result = Max - Min;
Console.WriteLine($"{Max} - {Min} = {Result}");