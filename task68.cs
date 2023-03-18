// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Accerman(int m, int n)
{
    if (m==0)return n+1;
    if (m>0 && n==0) return Accerman(m-1,1);
    if (m>0 && n>0) return Accerman (m-1,Accerman(m, n-1));
    else return -1;
}

System.Console.WriteLine("Введите M");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());

int Acc = Accerman(m,n);
System.Console.WriteLine(Acc);