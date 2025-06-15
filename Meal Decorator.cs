public abstract class MealDecorator : Meal
{
    protected Meal _meal;

    public MealDecorator(Meal meal) { _meal = meal; }
    public override string GetDescription() => _meal.GetDescription();
    public override double GetCost() => _meal.GetCost();
}

public class ExtraCheese : MealDecorator
{
    public ExtraCheese(Meal meal) : base(meal) { }
    public override string GetDescription() => base.GetDescription() + ", Extra Cheese";
    public override double GetCost() => base.GetCost() + 1.5;
}

public class Drink : MealDecorator
{
    public Drink(Meal meal) : base(meal) { }
    public override string GetDescription() => base.GetDescription() + ", Drink";
    public override double GetCost() => base.GetCost() + 2.0;
}

public class Sauce : MealDecorator
{
    public Sauce(Meal meal) : base(meal) { }
    public override string GetDescription() => base.GetDescription() + ", Sauce";
    public override double GetCost() => base.GetCost() + 0.75;
}
