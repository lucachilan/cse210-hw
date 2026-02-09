public class Square : Shape {
    private double _side = 0;

    public void SetSide(double side)
    {
        _side = side;
    }
    public double GetSide()
    {
        return _side;
    }

    public Square(double side, string color):base(color)
    {
        SetSide(side);
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}