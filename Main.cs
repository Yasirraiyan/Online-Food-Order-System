class Program
{
    static void Main(string[] args)
    {
        Meal meal = MealFactory.CreateMeal("Pizza");
        meal = new ExtraCheese(meal);
        meal = new Drink(meal);

        IPreparationStrategy prep = new IndianPreparation();
        var notifier = new OrderNotifier();
        notifier.Attach(new DeliverySystem());

        Order order = new Order(meal, prep, notifier);
        Console.WriteLine("Initial Order: " + meal.GetDescription() + " | Cost: $" + meal.GetCost());

        order.Proceed(); 
        order.Proceed(); 
        order.Proceed(); 
        order.Proceed(); 
    }
}
