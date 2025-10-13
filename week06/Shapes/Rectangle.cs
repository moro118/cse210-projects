using System.Security.Principal;

public class Rectangle : Shape
{
    private double _lenght;
    private double _width;

    public double GetLenght()
    {
        return _lenght;

    }
    public void SetLenght(double lenght) 
    {
        _lenght = lenght;
    }

    public double GetWidth()
    {
        return _width;
    }
    public void SetWidth(double width)
    {
        _width = width;
    }
    public Rectangle(double lenght, double width, string color): base(color)
    {
        _lenght = lenght;
        _width = width;
    }
    public override double GetArea()
    {
        return _lenght * 2 + _width * 2;
    }
 }