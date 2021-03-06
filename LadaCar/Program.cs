﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace LadaCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Лада", CarCategory.D) { Color = ConsoleColor.DarkMagenta };
            try
            {
                Console.WriteLine(car.CarPassport.Owner.Name);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Ошибка: У лады нет хозяина");
            }
            Driver driver = new Driver(new DateTime(2009, 12, 23), "Вольдемар");
            driver.Category.Add(DriverCategory.B);
            driver.Category.Add(DriverCategory.C);
            try
            {
                car.ChangeOwner(driver, "o777oo");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nНе получилось закрепить машину за водителем. Ошибка: " + e.Message);
            }
            driver.Category.Add(DriverCategory.D);
            car.ChangeOwner(driver, "o777oo");
            Console.WriteLine("\nНомер машины водителя: {0} \nВладелец машины: {1}", driver.Car.CarNumber, car.CarPassport.Owner.Name);
            Console.ReadKey();
        }
    }
}
