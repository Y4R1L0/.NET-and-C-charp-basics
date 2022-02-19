using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Extentions
{
    internal static class ComplexExtentions
    {
        public static DataTypes.Complex Reflect(this DataTypes.Complex c)
        {
            return new DataTypes.Complex { Im = c.Re, Re = c.Im };
        }
    }
}
