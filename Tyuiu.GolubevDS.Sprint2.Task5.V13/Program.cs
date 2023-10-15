using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GolubevDS.Sprint2.Task5.V13.Lib;
namespace Tyuiu.GolubevDS.Sprint2.Task5.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Голубев Д.С | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант 7                                                               *");
            Console.WriteLine("* Выполнил: Голубев Дмитрий Сергеевич | АСОиУб-23-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch, вычисляет       *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("* Условие: С начала 1990 года по некоторый день прошло n месяцев и 2 дня. *");
            Console.WriteLine("* Определить название месяца (январь, февраль и т. п.) этого дня.         *");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Укажите с какого года ведется отсчёт: ");
            int startYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Укажите сколько месяцев прошло со 2 января этого года: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: *");
            Console.WriteLine("***************************************************************************");

            string resultMonthName = ds.FindMonthName(startYear, n);
            Console.WriteLine($"С начала {startYear} года прошло " + n + " месяцев");
            Console.WriteLine("Тогда сейчас " + resultMonthName);
            Console.ReadKey();
        }
    }
}
