using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10266914___POE
{
    public class Recipe
    {
        //ArrayList which stores the data once entered//
        public ArrayList ingredient = new ArrayList();
        public ArrayList steps = new ArrayList();


        //Method which allows you to input data for the various options//
        public void Details()
        {
            Console.WriteLine("Enter the number of ingredients: ");
            int IngNumber;
            while (!int.TryParse(Console.ReadLine(), out IngNumber) || IngNumber <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid number greater than 0.");
            }

            for (int i = 0;i < IngNumber; i++)
            {
               
                Console.WriteLine("Name of Ingredient: ");
                string name = Console.ReadLine();


                Console.WriteLine("Quantity of Ingredient: ");
                int quantity = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your unit of Measurement(eg.tablespoon/teaspoon)");
                string measurement = Console.ReadLine();

                ingredient.Add(new Ingredients(name, quantity, measurement));

            }

            Console.WriteLine("Please enter the number of steps for recipe: ");
            int stepNumber = Convert.ToInt32(Console.ReadLine());

            for(int j = 0;j <  stepNumber; j++)
            {
                Console.WriteLine($"Step: {j + 1}: ");
                string description = Console.ReadLine();

                steps.Add(description);
            }
        }

        //mehtod for displaying info after inputing the necessary values//
        public void DisplayInfo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("====================");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nRecipe");
            Console.WriteLine("Ingredients:");
            Console.ResetColor();

            foreach(Ingredients ingredients in ingredient)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{ingredients.Quantity} {ingredients.Measurement} of {ingredients.Name}");
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("====================");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("====================");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Steps: ");
            Console.ResetColor();
            for(int i = 0; i < steps.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{i + 1}. {steps[i]}");
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("====================");
            Console.ResetColor();

        }

        //Method for scaling the quantity of the recipe//
        public void ScaledRecipe()
        {
            Console.Write("\nEnter scaling factor (0.5 for half, 2 for double, 3 for triple): ");
            int factor = Convert.ToInt32(Console.ReadLine());
            foreach (Ingredients ingredients in ingredient)
            {
                ingredients.Quantity *= factor;
            }
        }

        //Method for reseting quantity of the recipe//
        public void RestQuantity()
        {
            foreach(Ingredients ingredients in ingredient)
            {
                ingredients.Quantity /= ingredients.Quantity;
            }
        }

        //Method for clearing the recipe to add a new one//
        public void ClearRecipe()
        {
            ingredient.Clear();
            steps.Clear();
        }
    }
}
