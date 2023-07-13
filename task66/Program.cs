// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int M, int N)
{
    if(M > N)
    {
        return 0;
    }
    return M + SumNumbers(M + 1, N);
}

int sum = SumNumbers(M, N);
Console.WriteLine($"Сумма от {M} до {N} = {sum}.");