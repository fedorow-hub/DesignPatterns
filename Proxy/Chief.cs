namespace Proxy;

public class Chief : IChief
{
    public IDictionary<int, string> GetStatuses()
    {
        Dictionary<int, string> statuses= new Dictionary<int, string>();

        statuses.Add(1, "ready");
        statuses.Add(2, "not ready");
        statuses.Add(3, "preparing");

        Thread.Sleep(2000);

        return statuses;
    }

    public IEnumerable<Order> GetOrders()
    {
        List<Order> orders= new List<Order>();

        orders.Add(new Order() { Name = "Burger", StatusID = RandomizeStatus() });
        orders.Add(new Order() { Name = "Pasta", StatusID = RandomizeStatus() });
        orders.Add(new Order() { Name = "Omelet", StatusID = RandomizeStatus() });

        return orders;
    }

    private static int RandomizeStatus()=> new Random().Next(1, 4);
}
