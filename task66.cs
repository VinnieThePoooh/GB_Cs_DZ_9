// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum(int m, int n)
{
    if (m>n)return 0;
    else return m + Sum(m+1,n);
}

System.Console.WriteLine("Введите M");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());

int SumNum = Sum(m,n);
System.Console.WriteLine(SumNum);