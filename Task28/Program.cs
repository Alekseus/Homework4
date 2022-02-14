// Подсчитайте сумму цифр в числе.

int number = new Random().Next(1, 10000);
int n = number;
int sum = 0;


while (number > 0)
{
    int digit = number % 10;
    sum = sum + digit;
    number = number / 10;
}

Console.Write($"Сумма цифр числа {n} равна {sum}");