using System;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryAF factoryaf = new FactoryAF();
            factoryaf.customers.Add(new Customer { FIO = "Азам Арарар Азор" });
            factoryaf.customers.Add(new Customer { FIO = "Изир Ум Абум" });
            factoryaf.customers.Add(new Customer { FIO = "Бужур Адык Чингик" });

            foreach (Customer customer in factoryaf.customers)
            {
                Console.WriteLine(customer.FIO);
                if (customer.car is null)
                {
                    Console.WriteLine("У него нет машины");
                }
                else
                {
                    Console.WriteLine($"Номер его машины = {customer.car.CarNumber}, Размер педалей = {customer.car.engine.PedalSize}");
                }
            }

            factoryaf.AddCar(12);
            factoryaf.AddCar(20);
            factoryaf.SaleCar();

            foreach (Customer customer in factoryaf.customers)
            {
                Console.WriteLine(customer.FIO);
                if (customer.car is null)
                {
                    Console.WriteLine("У него нет машины");
                }
                else
                {
                    Console.WriteLine($"Номер его машины = {customer.car.CarNumber}, Размер педалей = {customer.car.engine.PedalSize}");
                }
            }
        }
    }
}
