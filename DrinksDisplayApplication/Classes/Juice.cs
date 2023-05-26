using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksDisplayApplication.Classes
{
    public class Juice : Drink
    {
        public Juice(string name, bool isCarbonated, string fruit) : base(name, isCarbonated)
        {
            this.Fruit = fruit;
        }
        private string Fruit { get; set; }

        public override string ObtainDrinkDescription()
        {
            return "Juice\n" + base.ObtainDrinkDescription() +
                "\nFruit used in the juice: " + this.Fruit;           
        }
    }
}
