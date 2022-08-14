using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите любое натуральное число  ");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];  int[] b = new int[n];
        for (int i = 0; i <= n; i++)
        {
            a[i] = i+1; b[i] = a[i]*a[i]*a[i];
            Console.WriteLine("Числа от 1 до n: " + a[i] + ", " + "числа от 1 до n в кубе: " + b[i]);
        }
            Console.ReadKey();
    }
}