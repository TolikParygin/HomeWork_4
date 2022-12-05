// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
int FineDegree(int firstNumber, int secondNumber)
{
    int result = 1;
    for (int count = 0; count < secondNumber; count++)
    {
        result = result * firstNumber;
    }
    return result;
}


Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());// Вводим первое число
Console.Write("Введите первое число: ");
int secondNumber = int.Parse(Console.ReadLine());// Вводим второе число
Console.WriteLine($"{firstNumber} , {secondNumber} -> {FineDegree(firstNumber, secondNumber)}");