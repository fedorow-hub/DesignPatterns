using System.Collections;

namespace Iterator.cs
{
    public class DinerMenuIteratorAdaptor : IEnumerator<MenuItem>
    {
        private DinerMenuIterator dinerMenuIterator;

        public DinerMenuIteratorAdaptor(DinerMenuIterator dinerMenuIterator)
        {
            this.dinerMenuIterator = dinerMenuIterator;
        }

        public MenuItem Current => dinerMenuIterator.Next();

        object IEnumerator.Current => dinerMenuIterator.Next();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            return dinerMenuIterator.HasNext();            
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
