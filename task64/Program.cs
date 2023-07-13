/*
Задача 64. Задать значение N. Написать программу, 
которая выведет все натуральные числа в промежутке 
от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void NaturalToLow(int n, int score)
{
    if (n < 0)
        Console.WriteLine("Your number is negative!");
    else
    {
    if (score > n)
        {
            return;
        }
    else
        {
            NaturalToLow(n, score + 1);
            Console.Write(score + " ");
        }
    }
}

Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalToLow(number, count);