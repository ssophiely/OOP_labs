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
        private static List<Airport> _list = new List<Airport>();

        /// <summary> приватный конструктор </summary>
        private AirportList() { }

        /// <summary> Пользовательский делегат </summary>
        public delegate void AirportListHandler(string message);

        /// <summary> Событие добавления объекта в список </summary>
        public static event AirportListHandler AddChange;

        /// <summary> Событие удаления объекта из списка </summary>
        public static event AirportListHandler DelChange;

        /// <summary> Метод получения длины списка </summary>
        public static int GetSize()
        {
            return _list.Count;
        }

        /// <summary>
        /// Метод добавления объекта в список
        /// </summary>
        /// <param name="item"> объект класса Airport </param>
        public static void Add(Airport item)
        {
            _list.Add(item);
            AddChange.Invoke($"Объект с ID {item.GetID()} успешно создан");
        }

        /// <summary>
        /// Метод добавления объекта в список
        /// </summary>
        /// <param name="i"> ID объекта </param>
        public static void Remove(int i)
        {
            if (i < _list.Count)
            {
                _list.RemoveAt(i);
                DelChange.Invoke($"Объект с ID {i} успешно удален");
            }
            else
            {
                DelChange.Invoke($"Объекта с ID {i} не существует");
            }
        }

        public static List<Airport> GetList()
        {
            return _list;
        }
    }
}
