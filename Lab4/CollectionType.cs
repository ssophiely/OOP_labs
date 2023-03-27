using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab4
{
    public class CollectionType<T> : IEnumerable, IComparable
    {
        public List<T> _list { get; } = new List<T>();
        public int _size { get; private set; } = 0;

        public CollectionType() { }

        public void Add(T item)
        {
            _list.Add(item);
            _size++;
        }

        public void Remove(int i)
        {
            if (i < _size)
            {
                _list.RemoveAt(i);
                _size--;
            }
        }

        public T this[int i]
        {
            get => _list[i];
            set => _list[i] = value;
        }

        public IEnumerator GetEnumerator() => _list.GetEnumerator();

        public int CompareTo(object o)
        {
            if (o is CollectionType<T> col) return _size.CompareTo(col._size);
            else throw new ArgumentException("Некорректное значение параметра");
        }
    }
}
