using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class UnidentifiedFieldException : Exception
    {
        public UnidentifiedFieldException(string message) : base(message) { }
    }
}
