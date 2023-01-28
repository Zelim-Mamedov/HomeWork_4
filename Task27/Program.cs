// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNumber(int number)
{
    int counter = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = number - number % 10;
        result = result + (number - advance);
        number = number / 10;
    }
    return result;
}

Console.Clear();
Console.WriteLine("Задача 27. Программа выдаёт сумму цифр в числе. ");
Console.Write("Введите число: ");
int number;
if (int.TryParse(Console.ReadLine(), out number))
    Console.WriteLine($"{number} -> {SumNumber(number)}");
else
    Console.WriteLine("Ошибка, введено некорректное значение. Введите число! ");