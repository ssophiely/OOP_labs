using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class ChildLibrary : LibraryType
    {
        public override string Type { get; } = "Детская";

        public override string Area { get; } = "Детская литература";
    }
}
