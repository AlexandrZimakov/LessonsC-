//Напишите метод, который на вход принимает число (number), а на выходе
//выводит все нечетные числа от 1 до number (включительно), после каждого числа
//должен быть знак пробела.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= number; i += 2){
    Console.Write(i + " ");
}
Console.WriteLine();