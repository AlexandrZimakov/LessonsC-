Console.Write("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if(99 < number && number < 1000){
    int leftDigit = number / 100;
    int rightDigit = number % 10;
    int result =  leftDigit + rightDigit;
    System.Console.WriteLine(result);
}
else{
    System.Console.WriteLine("Число не трехзначное");
}
