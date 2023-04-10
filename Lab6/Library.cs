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

        public static List<Library> All = new List<Library>();

        public Library(string name, int books, double rating, LibraryType type)
        {
            Name = name;
            Books = books;
            Rating = rating;
            Type = type;
        }

        public static void Add(Library _library)
        {
            All.Add(_library);
        }
        public override string ToString()
        {
            return $"Тип библиотеки: {Type.Type}" + "\r" + "\n" + $"Специализация: " +
                $"{Type.Area}" + "\r" + "\n" + $"Название библиотеки: {Name}" + "\r" + "\n" +
                $"Количество книг: {Books}" + "\r" + "\n" + $"Рейтинг: {Rating}" + "\r" + "\n";
        }
    }
}
