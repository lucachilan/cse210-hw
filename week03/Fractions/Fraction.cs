class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        SetTop(1);
        SetBottom(1);
    }
    public Fraction(int wholeNumber)
    {
        SetTop(wholeNumber);
        SetBottom(1);
    }
    public Fraction(int top, int bottom)
    {
        SetTop(top);
        SetBottom(bottom);
    }

    public int GetTop()
    {
        return _top;
    }
    void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string fractionString = _top+"/"+_bottom;
        return fractionString;
    }
    public double GetDecimalValue()
    {
        double decimalValue = (double)_top / (double)_bottom;
        return decimalValue;
    }

}