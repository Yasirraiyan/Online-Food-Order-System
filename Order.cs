public class Order
{
    private IOrderState _state;
    private Meal _meal;
    private IPreparationStrategy _prepStrategy;
    private OrderNotifier _notifier;

    public Order(Meal meal, IPreparationStrategy prepStrategy, OrderNotifier notifier)
    {
        _meal = meal;
        _prepStrategy = prepStrategy;
        _notifier = notifier;
        _state = new PlacedState();
    }

    public void SetState(IOrderState state)
    {
        _state = state;
        Console.WriteLine("Order Status: " + _state.GetStatus());
    }

    public void Proceed()
    {
        _state.Next(this);
        if (_state is PreparingState)
        {
            _prepStrategy.Prepare(_meal);
            _notifier.Notify("Order is prepared: " + _meal.GetDescription());
        }
    }

    public string GetStatus() => _state.GetStatus();
    public Meal GetMeal() => _meal;
}
