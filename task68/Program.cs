// // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// // m = 2, n = 3 -> A(m,n) = 9
// // m = 3, n = 2 -> A(m,n) = 29

int number(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return number(m - 1, 1);
    }
    else
    {
        return (number(m - 1, number(m, n - 1)));
    }
}


Console.WriteLine("Введите число m ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n ");
int numberN = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(number(numberM, numberN));