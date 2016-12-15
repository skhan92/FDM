using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOExample
{
    public class InvalidTextFilePathException : FormatException
    {
        public InvalidTextFilePathException() : base()
        {

        }

        public InvalidTextFilePathException(string message) : base(message)
        {

        }
    }
}
