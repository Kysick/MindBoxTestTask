using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MindBox.Utility;
using MindBox.Interfaces;

namespace MindBox.Figures
{
    public class Triangle : IFigure
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }



        public Triangle(double sideA, double sideB, double sideC)
        {
            CorrectnessCheck.CheckNum(sideA);
            CorrectnessCheck.CheckNum(sideB);
            CorrectnessCheck.CheckNum(sideC);
            CorrectnessCheck.CheckTriangle(sideA, sideB, sideC);

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double GetSquare()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public bool IsRightTriangle(double sideA, double sideB, double sideC)
        {

            double sideASquared = Math.Pow(sideA, 2);
            double sideBSquared = Math.Pow(sideB, 2);
            double sideCSquared = Math.Pow(sideC, 2);

            if (sideASquared + sideBSquared == sideCSquared ||
                sideASquared + sideCSquared == sideBSquared ||
                sideBSquared + sideCSquared == sideASquared)
            {
                return true;
            }

            return false;
        }
    }
}
