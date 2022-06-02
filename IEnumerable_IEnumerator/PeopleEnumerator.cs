using System.Collections;

namespace IEnumerable_IEnumerator
{
    // Whenever you implement IEnumerable, you MUST implement IEnumerator
    internal class PeopleEnumerator : IEnumerator
    {
        public Person[] _people;

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Person Current
        {
            get
            {
                try
                {
                    return _people[position];
                }
                catch(IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        // Enumerators are positioned before the first element
        // until the first MoveNext() call
        int position = -1;



        public PeopleEnumerator(Person[] list)
        {
            _people = list;
        }

        public bool MoveNext()
        {
            position++;
            return position < _people.Length;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
