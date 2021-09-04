using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            x:
            Console.WriteLine("Введите число в десятичной системе");
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Результат: ");
            Console.WriteLine(Convert.ToString(x, 16).ToUpper());
            goto x;
        }
    }
}
