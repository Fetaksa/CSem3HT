// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10000 && number <= 99999)
{
    int num1 = number / 10000;
    int num2 = number / 1000 % 10;
    int num4 = number / 10 % 10;
    int num5 = number % 10;


if (num1 == num5 && num2 == num4) Console.WriteLine($"Число {number} является палиндромом");
else Console.WriteLine($"Число {number} НЕ является палиндромом");
}

else Console.WriteLine("Введено некорректное число. Введите пятизначное число.");