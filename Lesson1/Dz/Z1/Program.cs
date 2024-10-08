//Напишите метод, который на вход принимает два целых числа и проверяет,
//делится ли первое число на второе. Если делится, выводите "делится", иначе
//выводите "не делится".

Console.Write("Введите первое целое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (secondNumber == 0){
    Console.Write("На ноль делить нельзя!");
} else if (firstNumber % secondNumber == 0){
    Console.Write("Делится");
} else {
    Console.Write("Неделится");
}