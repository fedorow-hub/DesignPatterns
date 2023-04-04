namespace Proxy;

public interface IChief
{
    public IDictionary<int, string> GetStatuses();
    public IEnumerable<Order> GetOrders();
}
