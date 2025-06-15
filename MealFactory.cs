public class MealFactory
{
    public static Meal CreateMeal(string type)
    {
        return type switch
        {
            "Pizza" => new Pizza(),
            "Burger" => new Burger(),
            "Pasta" => new Pasta(),
            _ => throw new ArgumentException("Invalid meal type")
        };
    }
}
