using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterface
{
    public class People<T>: ICollection<T>
    {
        private List<T> _people;

        public People() { }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            _people.Add(item);
        }

        public void Clear()
        {
            _people.Clear();
        }

        public bool Contains(T item)
        {
            return _people.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _people.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            return _people.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new PeopleEnumerator<T>(_people.ToArray());
        }
    }
}
