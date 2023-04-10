using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class LibraryFabric
    {
        public Dictionary<string, LibraryType> libs = new Dictionary<string, LibraryType>();

        public LibraryFabric()
        {
            libs.Add("Kids", new ChildLibrary());
            libs.Add("Public", new PublicLibrary());
            libs.Add("University", new UniLibrary());
        }

        public LibraryType GetLibrary(string key)
        {
            return libs[key];
        }
    }
}
