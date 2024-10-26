//Напишите программу, которая выведет все натуральные числа в
//промежутке от M до N. Используйте рекурсию и не используйте циклы.


int M = ReadInt("Введите число M: ");
int N = ReadInt("Введите число N: ");

PrintRange(M, N);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintRange(int M, int N)
{
    if (M > N)
    {
        return;
    }
    Console.Write(M);

    if (M < N)
    {
        Console.Write(", ");
        PrintRange(M + 1, N);
    }
}