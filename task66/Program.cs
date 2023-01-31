// Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.



void Printnumber(int numberM, int numberN, int sum)
{
    if (numberM > numberN)
    {
        Console.WriteLine(sum);
        return;
    }
    sum = sum + (numberM++);
    Printnumber(numberM, numberN, sum);
}


Console.WriteLine("Введите число m ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n ");
int numberN = Convert.ToInt32(Console.ReadLine());
int sum = 0;
Printnumber(numberM, numberN, sum);