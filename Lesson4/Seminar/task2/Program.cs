void Main()
{
    int sizeOfArray = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(sizeOfArray, 0, 10);
    PrintArray(array);
    Console.WriteLine(CountElements(array));
}

int CountElements(int[] array)
{
    int count = 0;
    foreach (int number in array)
    {
        if (number % 10 == 1 && number % 7 == 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        System.Console.Write(arrayForPrint[i] + " ");
    }
    System.Console.WriteLine();
}

int[] GenerateArray(int size, int minRange, int maxRange)
{
    int[] tempArray = new int[size];
    Random temp = new Random();
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = temp.Next(minRange , maxRange + 1);
    }
    return tempArray;
}

int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();