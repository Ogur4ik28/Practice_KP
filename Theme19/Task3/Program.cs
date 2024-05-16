using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /// <summary>
    /// Класс для работы с двумерными массивами.
    /// </summary>
    class TwoDimensionalArray
    {
        private int[,] array;
        private int rows;
        private int columns;

        /// <summary>
        /// Конструктор класса TwoDimensionalArray.
        /// </summary>
        /// <param name="rows">Количество строк массива.</param>
        /// <param name="columns">Количество столбцов массива.</param>
        public TwoDimensionalArray(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            array = new int[rows, columns];
        }

        /// <summary>
        /// Индексатор для доступа к элементам массива.
        /// </summary>
        /// <param name="row">Индекс строки.</param>
        /// <param name="column">Индекс столбца.</param>
        /// <returns>Элемент массива по указанным индексам.</returns>
        public int this[int row, int column]
        {
            get { return array[row, column]; }
            set { array[row, column] = value; }
        }

        /// <summary>
        /// Возвращает количество строк в массиве.
        /// </summary>
        /// <returns>Количество строк в массиве.</returns>
        public int GetRowCount()
        {
            return rows;
        }

        /// <summary>
        /// Возвращает количество столбцов в массиве.
        /// </summary>
        /// <returns>Количество столбцов в массиве.</returns>
        public int GetColumnCount()
        {
            return columns;
        }

        /// <summary>
        /// Перегрузка оператора умножения для умножения двух двумерных массивов.
        /// </summary>
        /// <param name="array1">Первый массив.</param>
        /// <param name="array2">Второй массив.</param>
        /// <returns>Результат умножения двух массивов.</returns>
        public static TwoDimensionalArray operator *(TwoDimensionalArray array1, TwoDimensionalArray array2)
        {
            if (array1.GetColumnCount() != array2.GetRowCount())
            {
                throw new ArgumentException("Несогласованные массивы");
            }

            TwoDimensionalArray result = new TwoDimensionalArray(array1.GetRowCount(), array2.GetColumnCount());

            for (int i = 0; i < array1.GetRowCount(); i++)
            {
                for (int j = 0; j < array2.GetColumnCount(); j++)
                {
                    int sum = 0;
                    for (int k = 0; k < array1.GetColumnCount(); k++)
                    {
                        sum += array1[i, k] * array2[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            return result;
        }
    }

    /// <summary>
    /// Главный класс программы.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            TwoDimensionalArray array1 = new TwoDimensionalArray(2, 3);
            TwoDimensionalArray array2 = new TwoDimensionalArray(3, 2);

            for (int i = 0; i < array1.GetRowCount(); i++)
            {
                for (int j = 0; j < array1.GetColumnCount(); j++)
                {
                    array1[i, j] = i * 2 + j;
                }
            }

            for (int i = 0; i < array2.GetRowCount(); i++)
            {
                for (int j = 0; j < array2.GetColumnCount(); j++)
                {
                    array2[i, j] = i + j * 2;
                }
            }

            TwoDimensionalArray result = array1 * array2;

            Console.WriteLine("Результат умножения:");
            for (int i = 0; i < result.GetRowCount(); i++)
            {
                for (int j = 0; j < result.GetColumnCount(); j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
