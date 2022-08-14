using System; 
class Program
{
    static void Main()
    {
        Console.Write("Введите любое пятизначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        string numberText = Convert.ToString(number);
        if ((number[0] = numberText[4]) && (number[1] = number[3]))
        {
            Console.WriteLine("Число является палиндромом");
        }
        else
            {
                Console.WriteLine("Число не является палиндромом");
            }
    }
}