// Задайте произвольный массив. Выведите его элементы, начиная с конца.
// Используйте рекурсию и не используйте циклы.

int[] array = { 1, 2, 3, 4, 5 };

PrintArrayReverse(array, array.Length - 1);

void PrintArrayReverse(int[] array, int index)
{
    if (index < 0)
    {
        return;
    }
    Console.Write(array[index]);
    if (index > 0)
    {
        Console.Write(", ");
        PrintArrayReverse(array, index - 1);
    }
}
