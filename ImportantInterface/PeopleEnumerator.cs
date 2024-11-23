using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterface
{
    public class PeopleEnumerator<T> : IEnumerator<T>
    {
        private T[] _people;
        private int _index;

        public T Current => _people[_index];

        object IEnumerator.Current => Current;

        public PeopleEnumerator(T[] people)
        {
            _people = people;
            _index = -1;
        }

        public void Dispose()
        {
            _people = new T[0];
        }

        public bool MoveNext()
        {
            _index++;

            return _index < _people.Length;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
