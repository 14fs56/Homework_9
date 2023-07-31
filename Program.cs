using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    class Program
    {
        static void Main()
        {
            Random Random = new Random();
            int minNumber = 1;
            int maxNumber = 6;
            int magicNumber = Random.Next(minNumber, maxNumber);

            Console.WriteLine("Угадай число");
            Console.WriteLine();
            Console.WriteLine("Загадано число от 1 до 5. Попробуйте его отгадать!");
            Console.WriteLine();
            Console.Write("Введите ваше число: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (magicNumber == input)
            {
                Console.WriteLine($"Да! Это число {magicNumber}!");
            }
            else
            {
                Console.WriteLine($"Нет! Это не {input} !\nЗагадано число {magicNumber} .");
            }
        }
    }
}
