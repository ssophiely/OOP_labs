using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class UniLibrary : LibraryType
    {
        public override string Type { get; } = "Вузовская";

        public override string Area { get; } = "Научная, художественная литература, учебные материалы";
    }
}
