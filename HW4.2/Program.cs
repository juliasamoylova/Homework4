// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number = Convert.ToInt32(Console.ReadLine());

int numLen(int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}
Console.WriteLine(numLen(number));
Console.WriteLine(number);

int result = 0;
while (number > 0)
{
    int Div(int number)
{
    number = number / Convert.ToInt32(Math.Pow(10, (numLen(number) - 1)));
    result = result + number;
}
    number = number%(Convert.ToInt32(Math.Pow(10,(numLen(number) - 1))));
}
Console.WriteLine($"Сумма цифр числа {number} равна {result}");