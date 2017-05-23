using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Car
    {
        public readonly string Model;
        public ConsoleColor Color = ConsoleColor.Blue;
        public string CarNumber { get; private set; }
        public readonly Category CarCategory;
        public readonly CarPassport CarPassport;

        public void ChangeOwner(Driver owner, string numb)
        {
            owner.OwnCar(this);
            CarNumber = numb;
            CarPassport.Owner = owner;
        }

        public Car(string model, Category category)
        {
            Model = model;
            CarCategory = category;
            CarPassport = new CarPassport(this);
        }
    }
}
