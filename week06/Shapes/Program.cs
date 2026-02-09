using System;
using System.Drawing;
using System.Dynamic;
using Microsoft.VisualBasic.FileIO;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> lShapes = new List<Shape>();
        Square square = new Square( 5, "red");
        Rectangle rectangle = new Rectangle(2,5,"blue");
        Circle circle = new Circle(4,"green");

        lShapes.Add(circle);
        lShapes.Add(square);
        lShapes.Add(rectangle);

        foreach(Shape shp in lShapes)
        {
            double area = shp.GetArea();
            string color = shp.GetColor();

            Console.WriteLine($"{area:F2}, {color}");
        }
    }
}