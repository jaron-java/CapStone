namespace Pantry.Recipes;

internal class Recipe
{
    public string Name { get; set; }
    public List<Measurements.Measurements> Ingredients { get; set; }
    public int Calories { get; set; }
    //Can probably loop through list INGREDIENTS and add these up
}