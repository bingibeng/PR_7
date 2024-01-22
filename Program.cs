using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая работа № 7";

            try
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                int n; // n - стартовый капитал в рублях
                double p; // p - процент
                int s; // s - сумма в рублях
                double counter = 0; // a - счетчик цикла

                Console.WriteLine("Здравствуйте!");
                Console.Write("Стартовый капитал(в рублях): ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Процент: ");
                p = Convert.ToDouble(Console.ReadLine());
                Console.Write("Сумма(в рублях): ");
                s = Convert.ToInt32(Console.ReadLine());

                int month = 0; // количество месяцев

                for (counter = n; counter < s;)
                {
                    counter += counter * p / 100;
                    double round_number = Math.Round( counter, 2); 
                    Console.WriteLine(month + 1 + " месяц - сумма: " + round_number);
                    month++;

                }   
             

                if (month <= 12)
                    Console.WriteLine("Через " + month + " месяцев накопим необходимую сумму");
                if (month > 12)
                    Console.WriteLine("Через " + (month / 12) + " лет и " + (month % 12) + " месяцев накопим необходимую сумму");
            }

            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка:введите число, а не символ");
            }
            catch (Exception e) // обработка исключений
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: что-то пошло не так");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
