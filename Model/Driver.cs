using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Model
{
    public class Driver
    {
        public DateTime LicenceDate { get; } //close #1
        public string Name { get; } //close #1

        public int Experience
        {
            set
            {
            }
            get
            {
                TimeSpan Difference = DateTime.Today - LicenceDate;
                return Difference.Days / 365; ;
            }
        }

        private List<DriverCategory> _category;

        public List<DriverCategory> Category
        {
            set
            { _category = value; }
            get
            { return _category ?? (_category = new List<DriverCategory>());  }
        }

        //public List<DriverCategory> GetOwnCategory()
        //{
        //    return _category ?? (_category = new List<DriverCategory>());
        //}

        //public void SetOwnCategory(List<DriverCategory> value)
        //{
        //    _category = value;
        //}

        public Car Car { get; private set; }

        public void OwnCar(Car car)
        {
            foreach (var i in Category)
            {
                //if (i.Equals(car.CarCategory))
                if (i.Equals((DriverCategory)car.CarCategory))
                {
                    Car = car;
                    return;
                }
            }
            throw new Exception("У водителя нет нужной категории");
        }

        public Driver(DateTime licence, string name)
        {
            LicenceDate = licence;
            Name = name;
        }
    }
}
