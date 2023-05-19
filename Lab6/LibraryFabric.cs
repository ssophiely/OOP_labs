using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class LibraryFabric
    {
        private static Dictionary<string, LibraryType> libs = new Dictionary<string, LibraryType>()
        { {"Kids", new ChildLibrary() },{"Public", new PublicLibrary() }, { "University", new UniLibrary()} };

        public static LibraryType GetLibrary(string key)
        {
            return libs[key];
        }
    }
}
