using Proxy;

IChief chief = new ChiefProxy(new Chief());

while (true)
{
    Thread.Sleep(2000);

    Console.Clear();

    Console.WriteLine("Welcome to coocker!\n");

    Console.WriteLine("==========Orders=========\n");

    IEnumerable<Order> orders = chief.GetOrders();

    foreach(Order order in orders)
    {
        string status = chief.GetStatuses().First(s=>s.Key == order.StatusID).Value;

        Console.WriteLine($"{order.Name}\t\t{status}");
    }

}
