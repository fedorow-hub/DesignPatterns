namespace Iterator.cs
{
    public class PancakeHouseIterator : IIterator
    {
        private List<MenuItem> items;
        private int position = 0;

        public PancakeHouseIterator(List<MenuItem> items)
        {
            this.items = items;
        }
        public bool HasNext()
        {
            if (position >= items.Count || items[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public MenuItem Next()
        {
            MenuItem menuItem = items[position];
            position = position + 1;
            return menuItem;
        }
    }
}
