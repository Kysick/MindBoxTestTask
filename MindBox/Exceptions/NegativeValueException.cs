using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox.Exceptions
{
    public class NegativeValueException : Exception
    {
        public double Value { get; set; }

        public NegativeValueException(double value)
        {
            Value = value;
        }

        public NegativeValueException(double value, string message) : base(message)
        {
            Value = value;
        }
    }
}
