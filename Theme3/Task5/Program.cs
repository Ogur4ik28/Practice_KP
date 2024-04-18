using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Product
    {
        public string Name { get; set; }
        public string StoreName { get; set; }
        public double Price { get; set; }

        public Product(string name, string storeName, double price)
        {
            Name = name;
            StoreName = storeName;
            Price = price;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Store: {StoreName}, Price: {Price}";
        }
    }

    class Warehouse
    {
        private Product[] products;

        public Warehouse(int capacity)
        {
            products = new Product[capacity];
        }

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

        public void SortByStoreName()
        {
            Array.Sort(products, (x, y) => x?.StoreName.CompareTo(y?.StoreName) ?? 0);
        }

        public void SortByName()
        {
            Array.Sort(products, (x, y) => x?.Name.CompareTo(y?.Name) ?? 0);
        }

        public void SortByPrice()
        {
            Array.Sort(products, (x, y) => x.Price.CompareTo(y.Price));
        }

        public static double operator +(Warehouse warehouse, Product product)
        {
            double totalPrice = warehouse.products.Sum(p => p?.Price ?? 0);
            totalPrice += product.Price;
            return totalPrice;
        }

        public int GetCapacity()
        {
            return products.Length;
        }
    }
    internal class Program
    {
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

        static void DisplayProducts(Warehouse warehouse)
        {
            for (int i = 0; i < warehouse.GetCapacity(); i++)
            {
                warehouse.DisplayProductByIndex(i);
            }
        }
    }
}
