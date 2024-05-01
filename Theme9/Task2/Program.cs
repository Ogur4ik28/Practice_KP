using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Car : IComparable<Car>
    {
        public string LicensePlate { get; set; }
        public string Color { get; set; }
        public string Owner { get; set; }
        public bool IsPresent { get; set; }

        public int CompareTo(Car other)
        {
            return string.Compare(this.LicensePlate, other.LicensePlate);
        }
    }

    class ParkingLot
    {
        private Car[] cars;

        public ParkingLot(int capacity)
        {
            cars = new Car[capacity];
        }

        public void AddCar(int index, Car car)
        {
            if (index >= 0 && index < cars.Length)
            {
                cars[index] = car;
            }
            else
            {
                Console.WriteLine("Недопустимый номер места");
            }
        }

        public Car GetCar(int index)
        {
            if (index >= 0 && index < cars.Length)
            {
                return cars[index];
            }
            else
            {
                Console.WriteLine("Недопустимый номер места");
                return null;
            }
        }

        public void SearchCarByLicensePlate(string licensePlate)
        {
            var foundCars = cars.Where(car => car != null && car.LicensePlate == licensePlate);

            foreach (var car in foundCars)
            {
                Console.WriteLine($"Найден автомобиль: {car.Color} {car.LicensePlate}, владелец: {car.Owner}");
            }
        }

        public void ShowPresentCars()
        {
            var presentCars = cars.Where(car => car != null && car.IsPresent);

            Console.WriteLine("Автомобили на стоянке:");
            foreach (var car in presentCars)
            {
                Console.WriteLine($"{car.Color} {car.LicensePlate}, владелец: {car.Owner}");
            }
        }

        public void ShowAbsentCars()
        {
            var absentCars = cars.Where(car => car != null && !car.IsPresent);

            Console.WriteLine("Отсутствующие на стоянке автомобили:");
            foreach (var car in absentCars)
            {
                Console.WriteLine($"{car.Color} {car.LicensePlate}, владелец: {car.Owner}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ParkingLot parkingLot = new ParkingLot(10);

            parkingLot.AddCar(0, new Car { LicensePlate = "A123BC", Color = "Черный", Owner = "Иванов", IsPresent = true });
            parkingLot.AddCar(1, new Car { LicensePlate = "B456DE", Color = "Синий", Owner = "Петров", IsPresent = false });
            parkingLot.AddCar(2, new Car { LicensePlate = "C789FG", Color = "Белый", Owner = "Сидоров", IsPresent = true });

            parkingLot.SearchCarByLicensePlate("A123BC");

            parkingLot.ShowPresentCars();
            parkingLot.ShowAbsentCars();

            Console.ReadKey();
        }
    }
}
