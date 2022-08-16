using System; 
class Program
{
    static void Main()
    {
        Console.Write("Введите шесть целых цифр, где первые три - координаты первой точки, а другие - координаты второй: ");
        int ax = Convert.ToInt32(Console.ReadLine());
        int ay = Convert.ToInt32(Console.ReadLine());
        int az = Convert.ToInt32(Console.ReadLine());
        int bx = Convert.ToInt32(Console.ReadLine());
        int by = Convert.ToInt32(Console.ReadLine());
        int bz = Convert.ToInt32(Console.ReadLine());
        int e = bx - ax;
        int d = by - ay;
        int f = bz - az;
        Console.Write("Расстояние между двумя точками в пространстве равно ");
        Console.WriteLine(Math.Sqrt(e * e + d * d + f * f));
    }
}
