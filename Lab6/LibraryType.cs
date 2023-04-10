using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public abstract class LibraryType
    {
        public abstract string Type { get; }

        public abstract string Area { get; }

        public LibraryType() { }
    }
}
