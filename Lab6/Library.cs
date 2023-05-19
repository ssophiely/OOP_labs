using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab6
{
    internal class Library
    {
        public string Name { get; set; }
        public int Books { get; set; }
        public double Rating { get; set; }

        public LibraryType Type { get; set; }

        private static List<Library> _all = new List<Library>();

        public Library(string name, int books, double rating, string key)
        {
            Name = name;
            Books = books;
            Rating = rating;
            Type = LibraryFabric.GetLibrary(key);
        }

        public static List<Library> GetList()
        {
            return _all;
        }

        public static void Add(Library _library)
        {
            _all.Add(_library);
        }
        public override string ToString()
        {
            return $"Тип библиотеки: {Type.Type}" + "\r" + "\n" + $"Специализация: " +
                $"{Type.Area}" + "\r" + "\n" + $"Название библиотеки: {Name}" + "\r" + "\n" +
                $"Количество книг: {Books}" + "\r" + "\n" + $"Рейтинг: {Rating}" + "\r" + "\n";
        }
    }
}
