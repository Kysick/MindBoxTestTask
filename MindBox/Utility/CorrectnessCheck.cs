using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MindBox.Exceptions;

namespace MindBox.Utility
{
    public static class CorrectnessCheck
    {
        public static bool CheckNum(double num)
        {
            if (num < 0)
                throw new NegativeValueException(num, $"Negative value: {num}");
           return true;
        }
        public static bool CheckTriangle(double sideA, double sideB, double sideC)
        {
            if(!((sideA < sideB + sideC) && (sideB < sideA + sideC) && (sideC < sideA + sideB)))
                throw new IrregularTriangleException(sideA, sideB, sideC, $"Irregular Triangle");
            return true;
        }

    }
}
