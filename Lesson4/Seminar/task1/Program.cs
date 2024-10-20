void Main()
{
    int a = 7;
    int b = 8;
    int c = 13;

    int d = 10;
    int e = 5;
    int f = 3;

    int result = Function(a, b, c);
    System.Console.WriteLine(result);

    int result2 = Function(d, e, f);
    System.Console.WriteLine(result2);
}

int Function(int firstValue, int secondValue, int thirdValue)
{
    int result = (firstValue + secondValue - thirdValue) * 2 + 3 * secondValue - 10;
    return result;
}

Main();
