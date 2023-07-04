using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox.Exceptions
{
    public class IrregularTriangleException : Exception
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public IrregularTriangleException(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public IrregularTriangleException(double sideA, double sideB, double sideC, string message) : base(message)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
    }
}

