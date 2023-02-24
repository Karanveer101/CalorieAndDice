using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Http5112_Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        [HttpGet]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            //declared and initialized variables
            int cheeseBurger = 461;
            int fishBurger = 431;
            int veggieBurger = 420;
            int noBurger = 0;

            int softDrink = 130;
            int orangeJuice = 160;
            int Milk = 118;
            int noDrink = 0;

            int fries = 100;
            int bakedPotato = 57;
            int chefSalad = 70;
            int noSide = 0;

            int applePie = 167;
            int sundae = 266;
            int fruitCup = 75;
            int noDessert = 0;




            //array of choices in each category of burger, drink, side, and dessert
            int[] burgerChoice = { cheeseBurger, fishBurger, veggieBurger, noBurger };
            int[] drinkChoice = { softDrink, orangeJuice, Milk, noDrink };
            int[] sideChoice = { fries, bakedPotato, chefSalad, noSide };
            int[] dessertChoice = { applePie, sundae, fruitCup, noDessert };

            //selects and adds choice from each category to get the total calories
            int totalCalories = burgerChoice[burger - 1] + drinkChoice[drink - 1] + sideChoice[side - 1] + dessertChoice[dessert - 1];

            //returns the total calories as a string
            string calories = "Your total calorie count is " + totalCalories;

            return calories;


        }

    }
}