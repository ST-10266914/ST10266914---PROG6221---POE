using ST10266914___POE;

internal class Program
{
    private static void Main(string[] args)
    {
        Recipe r = new Recipe();

        Boolean valid = false;

        //A while loop for retruning to the menu once you have entered a recipe//
        while (!valid)
        {
            Console.WriteLine("Welcome to the recipe app:\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("====================");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                "1. Enter a recipe \n" +
                "2. Scale Recipe \n" +
                "3. Reset Quantites \n" +
                "4. Enter new recipe \n" +
                "5. Exit");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("====================");
            Console.ResetColor();

            Console.WriteLine("Please choose your option: ");
            try
            {
                int option = Convert.ToInt32(Console.ReadLine());

                //A case switch for the differnt options//
                switch (option)
                {
                    case 1:
                        r.Details();
                        r.DisplayInfo();
                        break;
                    case 2:
                        r.ScaledRecipe();
                        r.DisplayInfo();
                        break;
                    case 3:
                        r.RestQuantity();
                        r.DisplayInfo();
                        break;
                    case 4:
                        r.ClearRecipe();
                        break;
                    case 5:
                        Console.WriteLine("Goodbye :)");
                        valid = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter a valid number.");
            }

        }
    }
}