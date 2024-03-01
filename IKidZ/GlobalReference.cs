using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKidZ
{
    public enum Operation
    {
        Addition,
        Subtraction,
        Multiplication,
        Division,
        NULL
    }
    public class GlobalReference
    {
        static public Operation Operation = Operation.NULL;
    }
}
