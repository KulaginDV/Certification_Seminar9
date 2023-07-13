/*
Задача 66. 
Задать значения M и N. Написать программу, которая 
найдёт сумму натуральных элементов в промежутке 
от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int FindSum (int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + FindSum(m, n);
        return res;
    }
}

void PrintSum (int m, int n)
{
    Console.Write(FindSum(m-1, n));
}

Console.Write("Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintSum(m, n);