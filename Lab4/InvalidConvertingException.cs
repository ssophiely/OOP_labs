using System;

namespace Lab4
{
    public class InvalidConvertingException : FormatException
    {
        private string _rtype;

        public InvalidConvertingException(string m, string type) : base(m)
        {
            switch (type)
            {
                case "StringToNumber":
                    _rtype = "int";
                    break;
                case "ParseSingle":
                    _rtype = "float";
                    break;
                case "ParseDouble":
                    _rtype = "double";
                    break;

            }
        }
        public string GetRtype() { return _rtype; }
    }
}
