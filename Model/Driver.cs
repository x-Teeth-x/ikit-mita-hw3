using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Driver
    {
        public readonly DateTime LicenceDate;
        public readonly string Name;

        public TimeSpan Experience => DateTime.Today - LicenceDate;

        private List<Category> _category;

        public List<Category> OwnCategory
        {
            get { return _category ?? (_category = new List<Category>()); }
            set { _category = value; }
        }
        public Car Car { get; private set; }

        public void OwnCar(Car car)
        {
            foreach (var i in OwnCategory)
            {
                if (i.Equals(car.CarCategory))
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
