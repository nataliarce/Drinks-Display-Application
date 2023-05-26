using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrinksDisplayApplication.Classes;
using System;

namespace DrinksDisplayApplicationTest
{
    [TestClass]
    public class DrinksDisplayTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "invalid number.")]
        public void AddIncorrectAlcoholContentForBeer_ThrowsException()
        {
            Drink beer = new Beer("Imperial", true, -5);
        }

        [TestMethod]
        public void ReturnCorrectSodaDescription()
        {
            Drink fanta = new Soda("Fanta", true);

            Assert.AreEqual(fanta.ObtainDrinkDescription(), "Soda\nName: Fanta\nIs it carbonated?: True");
        }

        [TestMethod]
        public void ReturnCorrectJuiceDescription()
        {
            Drink appleJuice = new Juice("Simply Apple", false, "apple");

            Assert.AreEqual(appleJuice.ObtainDrinkDescription(), "Juice\nName: Simply Apple\nIs it carbonated?: False" +
                "\nFruit used in the juice: apple");
        }

        [TestMethod]
        public void ReturnCorrectBeerDescription()
        {
            Drink budLight = new Beer("Bud Light", true, 9);

            Assert.AreEqual(budLight.ObtainDrinkDescription(), "Beer\nName: Bud Light\nIs it carbonated?: True" +
                "\nAlcohol content of the beer: 9%");
        }
    }
}
