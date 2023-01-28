// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
//
// 3, 5 -> 243 (3⁵)
//
// 2, 4 -> 16

int Exponentiation(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
        result = result * numberA;
    return result;
}

Console.Clear();
Console.WriteLine("Задача 25. Программа возводит число A в натуральную степень числа B.");

Console.WriteLine("Введите первое положительное однозначное  число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе положительное однозначное число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(numberA, numberB);
if (numberA > 0 && numberA < 9 && numberB > 0 && numberB < 9)
{
    Console.WriteLine($"{numberA}, {numberB} -> {exponentiation}");
}
else Console.WriteLine("Ошибка, не верный ввод! ");