/*
Задача 68. 
Написать программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    else
    {
        return (AkkermanFunction(m - 1, AkkermanFunction(m, n - 1)));
    }
}

void PrintAkkermanFunction(int m, int n)
{
    Console.Write($"Decision is: " + AkkermanFunction(m, n)); 
}

Console.Write("Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintAkkermanFunction(m,n);