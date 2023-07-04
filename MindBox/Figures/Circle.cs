using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MindBox.Utility;
using MindBox.Interfaces;

namespace MindBox.Figures
{
    public class Circle : IFigure
    {
        public double Radius { get; }

        public double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }


        public Circle(double radius)
        {
            CorrectnessCheck.CheckNum(radius);
            Radius = radius;
        }


    }
}
