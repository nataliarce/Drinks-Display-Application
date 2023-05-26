using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksDisplayApplication.Classes
{
    public class Beer: Drink
    {
        private int alcoholContent;
        public Beer(string name, bool isCarbonated, int alcoholContent) : base(name, isCarbonated)
        {
            this.AlcoholContent = alcoholContent;
        }
        public int AlcoholContent
        {
            get
            {
                return alcoholContent;
            }

            set
            {
                if(value < 0 || value > 100)
                {
                    throw new ArgumentException("invalid number for alcohol content", 
                        nameof(alcoholContent));
                }
                this.alcoholContent = value;
            }
        }

        public override string ObtainDrinkDescription()
        {
            return "Beer\n" + base.ObtainDrinkDescription() +
                "\nAlcohol content of the beer: " + this.AlcoholContent + "%";
        }
    }
}
