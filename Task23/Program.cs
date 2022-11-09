// Напишите программу, которая принимает на вход число (N)
// и выдает таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Cubes(int num)
{
    if (num > 0)
    {
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine($"{i}   {i * i * i}");
        }
    }
    else
    {
        Console.WriteLine("Введите число больше нуля.");
    }
}

Cubes(number);
