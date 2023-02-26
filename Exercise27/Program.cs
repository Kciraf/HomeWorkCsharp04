// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigits(int number)
{
    int result = 0;
    while (number >= 10)
    {
        result = result + number % 10;
        number = number / 10;
    }
    result = result + number;
    return result;
}

System.Console.Write("Введите число: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
System.Console.WriteLine("Сумма цифр в числе: " + SumDigits(num));
