namespace Pantry;

class Program
{
    static void Main()
    {
        Database.Ingredients.CreateConnection();
        Database.Measurements.CreateConnection();
        Database.Recipes.CreateConnection();
        Database.RecipeBooks.CreateConnection();
        Console.WriteLine("Yay!");
    }
}