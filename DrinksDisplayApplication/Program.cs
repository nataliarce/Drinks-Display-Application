using DrinksDisplayApplication.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksDisplayApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Drink orangeJuice = new Juice("Orange juice", false, "orange");
                Drink budweiser = new Beer("Budweiser", true, 5);
                Drink pepsi = new Soda("Pepsi", true);

                Drink[] drinks = {orangeJuice, budweiser, pepsi};

                Console.WriteLine("List of drinks:\n");
                foreach(Drink d in drinks)
                {
                    Console.WriteLine(d.ObtainDrinkDescription() + "\n");
                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\nPress enter to close...");
                Console.ReadLine();
            }

        }
    }
}
