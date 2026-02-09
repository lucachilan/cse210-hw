public class Rectangle : Shape {
    private double _width = 0;
    private double _height = 0;


    public void SetWidth(double width) 
    {
        _width = width;
    }

    public double GetWidth()
    {
        return _width;
    }

    public void SetHeight(double height)
    {
        _height = height;
    }

    public double GetHeight()
    {
        return _height;
    }

    public Rectangle(double width, double height, string color):base(color)
    {
        SetWidth(width);
        SetHeight(height);
    }

    public override double GetArea()
    {
        return _width * _height;
    }
}