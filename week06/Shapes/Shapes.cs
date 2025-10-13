public class Shape
{
    string _color;

    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public Shape(string color)
    {
        this._color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }
 }