using System;
using System.Linq;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Загадайте слово");
            string a = Console.ReadLine();
            Console.Clear();
            string word = String.Join("", a.Select(v => '*')), wordsym = a;
            do
            {
                Console.WriteLine($"Загаданное слово: {word}\n Введите букву");
                char letter;
                if (char.TryParse(Console.ReadLine(), out letter))
                {
                    if (a.Contains(letter))
                        word = String.Join("", word.Select((v, i) => wordsym[i] == letter ? letter : word[i]));
                    else
                    {
                        Console.WriteLine("Такой буквы нет");
                    }

                }
                else
                {
                    Console.WriteLine("Можно ввести только один символ");
                }

            } while (word.Where(v => v == '*').Count() != 0);
            Console.WriteLine("Вы угадали слово");
            Console.ReadKey();
        }
    }
}
