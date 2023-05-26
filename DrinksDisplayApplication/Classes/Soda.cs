using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksDisplayApplication.Classes
{
    public class Soda: Drink
    {
        public Soda(string name, bool isCarbonated) : base(name, isCarbonated){}
        public override string ObtainDrinkDescription()
        {
            return "Soda\n" + base.ObtainDrinkDescription();
        }
    }
}
