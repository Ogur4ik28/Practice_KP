using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    /// <summary>
    /// Делегат для вычисления параметров фигур.
    /// </summary>
    /// <param name="radius">Радиус фигуры.</param>
    /// <returns>Значение параметра фигуры.</returns>
    delegate double CalcFigure(double radius);

    /// <summary>
    /// Основной класс программы.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            CalcFigure CF;

            CF = Get_Length;
            Console.WriteLine("Длина окружности: " + CF(5));

            CF = Get_Area;
            Console.WriteLine("Площадь круга: " + CF(5));

            CF = Get_Volume;
            Console.WriteLine("Объем шара: " + CF(5));

            Console.ReadKey();
        }

        /// <summary>
        /// Метод для вычисления длины окружности.
        /// </summary>
        /// <param name="radius">Радиус окружности.</param>
        /// <returns>Длина окружности.</returns>
        static double Get_Length(double radius)
        {
            return 2 * Math.PI * radius;
        }

        /// <summary>
        /// Метод для вычисления площади круга.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        /// <returns>Площадь круга.</returns>
        static double Get_Area(double radius)
        {
            return Math.PI * radius * radius;
        }

        /// <summary>
        /// Метод для вычисления объема шара.
        /// </summary>
        /// <param name="radius">Радиус шара.</param>
        /// <returns>Объем шара.</returns>
        static double Get_Volume(double radius)
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
        }
    }
}
