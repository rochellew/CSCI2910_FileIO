using System.Collections;

namespace IEnumerable_IEnumerator
{
    // Collection of Person objects.
    // Implements the IEnumberable interfaces, so that
    // it can be used with ForEach syntax.
    internal class People : IEnumerable
    {
        // fields
        private Person[] _people;

        // Constructor
        public People(Person[] pArray)
        {
            _people = new Person[pArray.Length];

            for(int i = 0; i < pArray.Length; i++)
            {
                _people[i] = pArray[i];
            }
        }

        // must be implemented by interface
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator() as IEnumerator;
        }

        public PeopleEnumerator GetEnumerator()
        {
            return new PeopleEnumerator(_people);
        }
    }
}
