using System.Collections;

namespace Adapter
{
    public class WildTurkey : ITurkey, IEnumerator
    {
        public object Current => throw new NotImplementedException();

        public void fly()
        {
            Console.WriteLine("I’m flying a short distance");
        }


        public void gobble()
        {
            Console.WriteLine("Gobble gobble");
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
