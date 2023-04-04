namespace Iterator.cs
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsVegiterian { get; set; }
        public double Price { get; set; }
        public MenuItem(string name, string description, bool isVegitarian, double price)
        {
            Name = name;
            Description = description;
            Price = price;
            IsVegiterian = isVegitarian;
        }
    }
}
