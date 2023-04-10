// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[10]; // Создание нового массива
void FillArray(int[] collection) // Заполнение массива случайными числами
{
    int length = collection.Length; // определение длины массива
    int index = 0;
    while (index < length)
     {
     collection[index] = new Random().Next(1, 10); 
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