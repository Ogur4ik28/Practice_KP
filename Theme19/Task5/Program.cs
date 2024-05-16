using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /// <summary>
    /// Класс, представляющий продукт.
    /// </summary>
    class Product
    {
        public string Name { get; set; }
        public string StoreName { get; set; }
        public double Price { get; set; }

        /// <summary>
        /// Конструктор класса Product.
        /// </summary>
        /// <param name="name">Наименование продукта.</param>
        /// <param name="storeName">Название магазина.</param>
        /// <param name="price">Цена продукта.</param>
        public Product(string name, string storeName, double price)
        {
            Name = name;
            StoreName = storeName;
            Price = price;
        }

        /// <summary>
        /// Переопределение метода ToString для отображения информации о продукте.
        /// </summary>
        /// <returns>Строка с информацией о продукте.</returns>
        public override string ToString()
        {
            return $"Name: {Name}, Store: {StoreName}, Price: {Price}";
        }
    }

    /// <summary>
    /// Класс, представляющий склад с товарами.
    /// </summary>
    class Warehouse
    {
        private Product[] products;

        /// <summary>
        /// Конструктор класса Warehouse.
        /// </summary>
        /// <param name="capacity">Вместимость склада (максимальное количество товаров).</param>
        public Warehouse(int capacity)
        {
            products = new Product[capacity];
        }

        /// <summary>
        /// Добавляет продукт на склад по указанному индексу.
        /// </summary>
        /// <param name="product">Продукт для добавления.</param>
        /// <param name="index">Индекс, по которому будет добавлен продукт.</param>
        public void AddProduct(Product product, int index)
        {
            if (index >= 0 && index < products.Length)
            {
                products[index] = product;
            }
            else
            {
                Console.WriteLine("Index out of range.");
            }
        }

        /// <summary>
        /// Отображает информацию о продукте по указанному индексу.
        /// </summary>
        /// <param name="index">Индекс продукта.</param>
        public void DisplayProductByIndex(int index)
        {
            if (index >= 0 && index < products.Length && products[index] != null)
            {
                Console.WriteLine(products[index]);
            }
            else
            {
                Console.WriteLine("Индекс товара не найден.");
            }
        }

        /// <summary>
        /// Отображает информацию о продукте по его названию.
        /// </summary>
        /// <param name="name">Название продукта.</param>
        public void DisplayProductByName(string name)
        {
            var product = products.FirstOrDefault(p => p != null && p.Name.ToLower() == name.ToLower());
            if (product != null)
            {
                Console.WriteLine(product);
            }
            else
            {
                Console.WriteLine("Не найдено имя товара.");
            }
        }

        /// <summary>
        /// Сортирует товары на складе по названию магазина.
        /// </summary>
        public void SortByStoreName()
        {
            Array.Sort(products, (x, y) => x?.StoreName.CompareTo(y?.StoreName) ?? 0);
        }

        /// <summary>
        /// Сортирует товары на складе по названию продукта.
        /// </summary>
        public void SortByName()
        {
            Array.Sort(products, (x, y) => x?.Name.CompareTo(y?.Name) ?? 0);
        }

        /// <summary>
        /// Сортирует товары на складе по цене.
        /// </summary>
        public void SortByPrice()
        {
            Array.Sort(products, (x, y) => x.Price.CompareTo(y.Price));
        }

        /// <summary>
        /// Перегрузка оператора сложения для расчета общей цены товаров на складе.
        /// </summary>
        /// <param name="warehouse">Склад с товарами.</param>
        /// <param name="product">Продукт для добавления цены.</param>
        /// <returns>Общая цена товаров на складе после добавления нового продукта.</returns>
        public static double operator +(Warehouse warehouse, Product product)
        {
            double totalPrice = warehouse.products.Sum(p => p?.Price ?? 0);
            totalPrice += product.Price;
            return totalPrice;
        }

        /// <summary>
        /// Возвращает вместимость склада (максимальное количество товаров).
        /// </summary>
        /// <returns>Вместимость склада.</returns>
        public int GetCapacity()
        {
            return products.Length;
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
            Warehouse warehouse = new Warehouse(5);

            warehouse.AddProduct(new Product("Ноутбук", "Электросила", 1500), 0);
            warehouse.AddProduct(new Product("Смартфон", "5 элемент", 800), 1);
            warehouse.AddProduct(new Product("Книга", "Книжный", 20), 2);
            warehouse.AddProduct(new Product("Наушники", "Электросила", 100), 3);
            warehouse.AddProduct(new Product("Кофемашина", "Товары для дома", 50), 4);

            Console.Write("Введите индекс товара: ");
            int prodInd = int.Parse(Console.ReadLine());
            Console.WriteLine($"Товар по инексу {prodInd}:");
            warehouse.DisplayProductByIndex(2);

            Console.WriteLine("\nВведите название товара для поиска:");
            string productName = Console.ReadLine();
            warehouse.DisplayProductByName(productName);

            Console.WriteLine("\nСортировка товаров по названию магазина:");
            warehouse.SortByStoreName();
            DisplayProducts(warehouse);

            Console.WriteLine("\nСортировка товаров по названию:");
            warehouse.SortByName();
            DisplayProducts(warehouse);

            Console.WriteLine("\nСортировка товаров по цене:");
            warehouse.SortByPrice();
            DisplayProducts(warehouse);

            Product newProduct = new Product("Монитор", "5 элемент", 300);
            warehouse.AddProduct(newProduct, 5);
            Console.WriteLine($"\nОбщая цена всех товаров: {warehouse + newProduct}");

            Console.ReadKey();
        }

        /// <summary>
        /// Отображает все товары на складе.
        /// </summary>
        /// <param name="warehouse">Склад с товарами.</param>
        static void DisplayProducts(Warehouse warehouse)
        {
            for (int i = 0; i < warehouse.GetCapacity(); i++)
            {
                warehouse.DisplayProductByIndex(i);
            }
        }
    }
}
