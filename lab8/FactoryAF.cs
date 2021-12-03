using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class FactoryAF
    {
        public List<Car> cars { get; } = new List<Car>();
        public List<Customer> customers { get; } = new List<Customer>();

        public void AddCar(int pedalSize) 
        { 
            cars.Add(new Car(pedalSize) { CarNumber = cars.Count + 1 }); 
        }
        public void SaleCar()
        {
            foreach (Customer customer in customers)
            {
                if (customer.car is null)
                {
                    if (cars.Any())
                    {
                        customer.car = cars[0];
                        cars.Remove(cars[0]);
                    }
                }
            }

            if (cars.Any())
            {
                cars.Clear();
            }
        }
    }
}
