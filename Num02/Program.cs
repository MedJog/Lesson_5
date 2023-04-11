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
     collection[index] = new Random().Next(-10, 10); 
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

int Sum(int[] coll) // функция для поиска суммы элементов
{
    int N = coll.Length;
    int index = 1;
    int result = 0;
    while (index < N)
    {
        result = result + coll[index];
        index = index + 2;
    }
 return result;
} 


FillArray(array);
PrintArray(array);
Console.WriteLine(); // вывод пустой строки 
int sum = Sum(array);
Console.WriteLine($"Сумма элементов равна {sum}.");
