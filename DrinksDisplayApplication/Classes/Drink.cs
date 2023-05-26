using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksDisplayApplication.Classes
{
    abstract public class Drink
    {
        public Drink(string name, bool isCarbonated)
        {
            this.Name = name;
            this.IsCarbonated = isCarbonated;
        }
        public string Name { get; set; }
        public bool IsCarbonated { get; set; }

        virtual public string ObtainDrinkDescription()
        {
            return "Name: " + this.Name + 
                "\nIs it carbonated?: " + this.IsCarbonated;
        }
    }
}
