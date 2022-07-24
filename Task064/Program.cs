// Задача 64: Задайте значения M и N. Напишите программу, которая выведет
//все натуральные числа в промежутке от M до N, кратные трём.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Clear();

void Zadacha64()
{
    int number1 = 1;
    int number2 = 20;
    Recursion(number1, number2);
    Console.WriteLine();

    void Recursion(int number1, int number2)
    {
        if (number1 > number2) return;
        if (number1 % 3 == 0)
        {
            Console.Write(number1 + " ");
        }
        number1++;
        Recursion(number1, number2);
    }
}

Zadacha64();