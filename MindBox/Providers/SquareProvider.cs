using MindBox.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox.Providers
{
    public class SquareProvider : IFigureProcessor
    {
        public double ProcessFigure(IFigure figure)
        {
            return figure.GetSquare();
        }
    }
}
