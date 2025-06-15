public interface IPreparationStrategy
{
    void Prepare(Meal meal);
}

public class IndianPreparation : IPreparationStrategy
{
    public void Prepare(Meal meal) => Console.WriteLine("Preparing " + meal.GetDescription() + " with Indian spices...");
}

public class ItalianPreparation : IPreparationStrategy
{
    public void Prepare(Meal meal) => Console.WriteLine("Preparing " + meal.GetDescription() + " with Italian herbs...");
}

public class AmericanPreparation : IPreparationStrategy
{
    public void Prepare(Meal meal) => Console.WriteLine("Preparing " + meal.GetDescription() + " in American style...");
}
