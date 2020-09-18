using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            MealBuilder mealBuilder = new MealBuilder();
            
            Meal vegMeal = mealBuilder.prepareVegMeal();
            Console.WriteLine("Veg Meal");
            vegMeal.showItems();
            Console.WriteLine("Gran Total: " + Convert.ToString(vegMeal.getCost()));

            Meal nonVegMeal = mealBuilder.prepareNonVegMeal();
            Console.WriteLine("Non Veg Meal");
            nonVegMeal.showItems();
            Console.WriteLine("Gran Total: " + Convert.ToString(nonVegMeal.getCost()));

        }
    }
}
