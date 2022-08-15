using System; 
class Program
{
    static void Main()
    {
        Console.Write("Введите любое пятизначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        string numberText = Convert.ToString(number);
        if ((numberText[0] == numberText[4]) && (numberText[1] == numberText[3]))
        {
            Console.WriteLine("Число является палиндромом");
        }
        else
            {
                Console.WriteLine("Число не является палиндромом");
            }
    }
}