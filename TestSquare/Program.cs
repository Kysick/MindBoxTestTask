using MindBox;
using MindBox.Figures;
using MindBox.Interfaces;
using MindBox.Providers;


IFigureProcessor figureProcessor = new SquareProvider();

    Console.WriteLine(figureProcessor.ProcessFigure(new Triangle(3, 4, 5)));
    Console.WriteLine(figureProcessor.ProcessFigure(new Circle(2)));
    Console.WriteLine(figureProcessor.ProcessFigure(new Triangle(1, 2, 3)));
