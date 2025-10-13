
public class Circle : Shape
{
    private double _radious;

    public Circle(double radious, string color) : base(color)
    {
        _radious = radious;
    }

    public void SetRadious(Double radious)
    {
        _radious = radious;
    }
    public double GetRadious()
    {
        return _radious;
    }

    public override double GetArea()
    {
        return 3.1416 * _radious;
    } 
   
}   