// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
//сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Zadacha66()
{
    int a = 1;
    int b = 5;
    Recursion(a, b);

    void Recursion(int a, int b, int sum = 0)
    {
        if (a > b) 
        {
            Console.WriteLine(sum);
            return;
        }
        sum += a;
        a++;
        Recursion(a, b, sum);
    }
}

Zadacha66();