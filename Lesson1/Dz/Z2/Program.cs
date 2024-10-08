//Напишите метод, который принимает на вход три числа и возвращает
//среднее из этих чисел (то есть не самое большое и не самое маленькое).

Console.Write("Введи первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if((a <= b && a >= c) || (a >= b && a <= c)){
    Console.WriteLine("Среднее из этих чисел: "+ a);
}else if((b <= a && b >= c) || (b >= a && b <= c)){
    Console.WriteLine("Среднее из этих чисел: "+ b);
}else{
    Console.WriteLine("Среднее из этих чисел: "+ c);
}