using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Exceptions
{
    internal class ComplexExceptions : Exception
    {
        public ComplexExceptions() : base("Invalid operation with complex number(s)")
        {

        }
        public ComplexExceptions(string message):base(message)
        {

        }
    }
}
