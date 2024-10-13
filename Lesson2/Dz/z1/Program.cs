//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.


Console.Write("Напиши число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0) {
    Console.Write("Кратно");
} else {
    Console.Write("Не кратно");
}