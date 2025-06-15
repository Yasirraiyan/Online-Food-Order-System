public interface IObserver
{
    void Update(string message);
}

public class DeliverySystem : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine("Delivery System Notified: " + message);
    }
}

public class OrderNotifier
{
    private List<IObserver> observers = new();

    public void Attach(IObserver observer) => observers.Add(observer);
    public void Notify(string message)
    {
        foreach (var observer in observers)
            observer.Update(message);
    }
}
