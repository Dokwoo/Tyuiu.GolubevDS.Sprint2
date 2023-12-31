﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GolubevDS.Sprint2.Task7.V14.Lib;
namespace Tyuiu.GolubevDS.Sprint2.Task7.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Голубев Д.С | АСОиУб-23-2";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                         *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                           *");
            Console.WriteLine("* Задание #7                                                                        *");
            Console.WriteLine("* Вариант #14                                                                       *");
            Console.WriteLine("* Выполнила: Голубев Дмитрий Сергеевич | АСОиУб-23-2                             *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные                     *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами X,Y        *");
            Console.WriteLine("* в заштрихованной области.                                                         *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");
            if (res)
            {
                Console.WriteLine("Точка находиться в заштрихлванной области");
            }
            else
            {
                Console.WriteLine("Точка не находиться в заштрихлванной области");
            }
            Console.ReadLine();

        }
    }
}
