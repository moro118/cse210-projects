using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeslist = new List<Shape>();
        shapeslist.Add(new Square("blue", 3));
        shapeslist.Add(new Rectangle(3, 5, "green"));
        shapeslist.Add(new Circle(4, "red"));
        foreach (Shape shape in shapeslist)
        { 
              Console.WriteLine("Shape area:" + shape.GetArea() + " Color:" + shape.GetColor());
        }
      
  
    }
}