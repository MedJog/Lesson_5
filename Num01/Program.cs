// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] array = new int[10]; // Создание нового массива
void FillArray(int[] collection) // Заполнение массива случайными числами
{
    int length = collection.Length; // определение длины массива
    int index = 0;
    while (index < length)
     {
     collection[index] = new Random().Next(100, 999); 
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

int Num(int[]coll)
{
    int N = coll.Length;
    int index = 0;
    int result = 0;
    while (index < N)
    {
        if (coll[index] / 2 == 0)
    {
        Console.WriteLine(coll[index]);
        result = result + 1;
    }
    index++;
    }
 return result;
}
 FillArray(array);
 PrintArray(array);
 Num(array);



