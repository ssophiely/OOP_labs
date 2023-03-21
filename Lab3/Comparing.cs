using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Comparing
    {
        /// <summary> Список объектов класса Airport </summary>
        private List<Airport> _list = new List<Airport>();

        /// <summary> Массив объектов класса Airport </summary>
        private Airport[] _array = new Airport[100000];

        /// <summary> Генератор случайных чисел </summary>
        private Random _random = new Random();

        /// <summary> Метод добавления объектов в список </summary>
        public void List_add()
        {
            for (int i = 0; i < 100000; i++)
            {
                _list.Add(new Airport());
            }
        }

        /// <summary> Метод добавления объектов в массив </summary>
        public void Array_add()
        {
            for (int i = 0; i < 100000; i++)
            {
                _array[i] = new Airport();
            }
        }

        /// <summary> Метод последовательной выборки объектов из списка </summary>
        public void List_remove_in_order()
        {
            for (int i = 0; i < 100000; i++)
            {
                Airport airport = _list[i];
            }
        }

        /// <summary> Метод последовательной выборки объектов из массива </summary>
        public void Array_remove_in_order()
        {
            for (int i = 0; i < 100000; i++)
            {
                Airport airport = _array[i];
            }
        }

        /// <summary> Метод последовательной выборки объектов из списка </summary>
        public void List_remove_random()
        {
            for (int i = 0; i < 100000; i++)
            {
                Airport airport = _list[_random.Next(0, 100000)];
            }
        }

        /// <summary> Метод последовательной выборки объектов из массива </summary>
        public void Array_remove_random()
        {
            for (int i = 0; i < 100000; i++)
            {
                Airport airport = _array[_random.Next(0, 100000)];
            }
        }

    }
}
