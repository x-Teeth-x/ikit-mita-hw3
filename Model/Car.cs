using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Car
    {
        public string Model { get; } //close #1
        public ConsoleColor Color = ConsoleColor.Blue;
        public string CarNumber { get; private set; }
        public readonly CarCategory CarCategory; //close #3
        public CarPassport CarPassport { get; } //close #1

        public void ChangeOwner(Driver owner, string numb)
        {
            owner.OwnCar(this);
            CarNumber = numb;
            CarPassport.Owner = owner;
        }

        public Car(string model, CarCategory category)
        {
            Model = model;
            CarCategory = category;
            CarPassport = new CarPassport(this);
        }
    }
}
