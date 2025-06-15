public interface IOrderState
{
    void Next(Order order);
    string GetStatus();
}

public class PlacedState : IOrderState
{
    public void Next(Order order)
    {
        order.SetState(new PreparingState());
    }
    public string GetStatus() => "Placed";
}

public class PreparingState : IOrderState
{
    public void Next(Order order)
    {
        order.SetState(new DispatchedState());
    }
    public string GetStatus() => "Preparing";
}

public class DispatchedState : IOrderState
{
    public void Next(Order order)
    {
        order.SetState(new DeliveredState());
    }
    public string GetStatus() => "Dispatched";
}

public class DeliveredState : IOrderState
{
    public void Next(Order order)
    {
        Console.WriteLine("Order already delivered.");
    }
    public string GetStatus() => "Delivered";
}
