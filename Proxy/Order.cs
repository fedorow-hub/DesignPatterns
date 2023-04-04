namespace Proxy;

public class Order
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string? Name { get; set; }

    public int StatusID { get; set; }

}
