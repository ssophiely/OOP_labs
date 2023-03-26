using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Lab3
{
    public class AirportList
    {
        /// <summary> Список объектов класса Airport </summary>
        private List<Airport> _list = new List<Airport>();

        /// <summary> Пользовательский делегат </summary>
        public delegate void AirportListHandler(string message);

        /// <summary> Событие добавления объекта в список </summary>
        public event AirportListHandler AddChange;

        /// <summary> Событие удаления объекта из списка </summary>
        public event AirportListHandler DelChange;

        /// <summary> конструктор </summary>
        public AirportList() { }

        /// <summary> Метод получения длины списка </summary>
        public int GetSize()
        {
            return _list.Count;
        }

        /// <summary>
        /// Метод добавления объекта в список
        /// </summary>
        /// <param name="item"> объект класса Airport </param>
        public void Add(Airport item)
        {
            _list.Add(item);
            AddChange.Invoke($"Объект с ID {item.GetID()} успешно добавлен в коллекцию");
        }

        /// <summary>
        /// Метод удаления объекта из списка
        /// </summary>
        /// <param name="i"> ID объекта </param>
        public void Remove(int i)
        {
            if (i < _list.Count)
            {
                _list.RemoveAt(i);
                DelChange.Invoke($"Объект с ID {i} успешно удален из коллекции");
            }
            else
            {
                DelChange.Invoke($"Объекта с ID {i} нет в коллекции");
            }
        }

        /// <summary> Метод получения списка </summary>
        public List<Airport> GetList()
        {
            return _list;
        }
    }
}
