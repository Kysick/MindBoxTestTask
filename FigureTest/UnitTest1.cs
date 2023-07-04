using MindBox.Figures;
using MindBox.Interfaces;
using MindBox.Providers;
using MindBox.Exceptions;

namespace FigureTest
{
    public class Tests
    {
        static IFigureProcessor figureProcessor = new SquareProvider();

        [SetUp]
        public static double SetupTriangle(Triangle triangle)
        {

            return figureProcessor.ProcessFigure(triangle);

        }

        [SetUp]
        public static double SetupCircle(Circle circle)
        {
            return figureProcessor.ProcessFigure(circle);
        }
    }
    class Test
    {


        [Test]
        public void Test1()
        {
            Assert.AreEqual(6.0, Tests.SetupTriangle(new Triangle(3, 4, 5)));
 

        }

        [Test]
        public void Test2()
        {
            Assert.Catch<NegativeValueException>(() => new Triangle(-1, 2, 3));
          //  Assert.Catch<OutOfMemoryException>(() => new Triangle(-1, 2, 3));
        }

        [Test]
        public void Test3()
        {
            Assert.Catch<IrregularTriangleException>(() => new Triangle(1, 2, 3));
           // Assert.Catch<OutOfMemoryException>(() => new Triangle(1, 2, 3));

        }


    }
}
